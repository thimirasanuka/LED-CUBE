

#define F_CPU	8000000
#define FOSC	8000000
#define	BAUD	9600
#define	MYUBRR	FOSC/16/BAUD-1

#define TRUE	1
#define FALSE	0

#include <avr/io.h>
#include <util/delay.h>
#include <avr/interrupt.h>

/************************************************************************/
/* PORT definition														*/
/* PORTA - data															*/
/* PORTB - Level Select													*/
/* PORTC - PC2, PC3, PC4 - Address select                               */
/************************************************************************/

/************************************************************************/
/* Function declaration                                                 */
/************************************************************************/

void init(void);


void EEOpen();
unsigned char EEWriteByte(unsigned int address,unsigned char data);
unsigned char EEReadByte(unsigned int address);

void USART_init(unsigned int ubrr);
void USART_Tx(unsigned char data);
unsigned char USART_Rx(void);

void display(void);
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/************************************************************************/
/* Variable declaration                                                 */
/************************************************************************/

unsigned char frame[64] = {		255,129,129,129,129,129,129,255,
								129,0,0,0,0,0,0,129,
								129,0,0,0,0,0,0,129,
								129,0,0,0,0,0,0,129,
								129,0,0,0,0,0,0,129,
								129,0,0,0,0,0,0,129,
								129,0,0,0,0,0,0,129,
								255,129,129,129,129,129,129,255};
								
unsigned char romRead = 0;

unsigned char rxdata = 'A';
unsigned char progdata = 0;
unsigned char dispdata = 0;
unsigned char readdata = 0;
unsigned char progBuffer[66];
unsigned int fstep = 0;			// first step
unsigned int lstep = 13;			// last step
unsigned int cstep = 0;		// current step
unsigned int frameloop = 1;


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

int main(void)
{
	sei();
	init();
	USART_init(MYUBRR);
	USART_Tx('S');
	

		unsigned char i = 0, j = 0, n= 0;


	while(1){
		//USART_Tx('A');
		if(progdata ==1 ){
			for(j=0;j<66;j++){
				progBuffer[j] = USART_Rx();
				USART_Tx('C');
			}
			unsigned int baseaddr = ((progBuffer[0]<<8)+progBuffer[1])*64;
			for(j=2;j<66;j++){
				EEWriteByte(baseaddr+j-2,progBuffer[j]);
			}
			
			progdata = 0;
			UCSRB |=(1<<RXCIE);
			USART_Tx('C');
		}
		
		if(dispdata==1){
			for( j = 2;j<66;j++){
				progBuffer[j] = USART_Rx();
			}
			for( j = 2;j<66;j++){
				//USART_Tx(progBuffer[j]);
				frame[j-2] = progBuffer[j];
			}
			dispdata = 0;
			UCSRB |=(1<<RXCIE);
		}
		
		for( j = 2;j<66;j++){
			
			frame[j-2] = EEReadByte((cstep*64)+j-2);
		//USART_Tx(frame[j-2]);
		}
		
		for(n=0;n<frameloop;n++){
			for(i = 0;i<8;i++){
				for(j=0;j<8;j++){
					PORTA = frame[i*8+j];
					PORTC = j<<2;
				}
				//_delay_us(5);
				PORTB = 1<<i;
				_delay_us(2000);
			}
		//	USART_Tx(n);
			//_delay_ms(10);
		}
		
		//_delay_ms(5);
		//USART_Tx(cstep);
		if(cstep<lstep){cstep++;}else{cstep = fstep;}
		
	}	
	return 0;

}
	

void init(void)
{
	DDRA = 0xFF;
	DDRB = 0xFF;
	DDRC = 0b00011100;
	//DDRD = 0xFF;

	EEOpen();
}
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


void USART_init(unsigned int ubrr){
	// Set baud rate
	UBRRH = (unsigned char) (ubrr>>8);
	UBRRL = (unsigned char) ubrr;

	// Enable Rx, Tx and RCI
	UCSRB = (1<<RXCIE)|(1<<RXEN)|(1<<TXEN);

	// Set frame format: 8 data, 2 stop bits
	UCSRC = (1<<URSEL)|(1<<USBS)|(3<<UCSZ0);
}

void USART_Tx(unsigned char data){
	while(!(UCSRA & (1<<UDRE)));
	UDR = data;
}

unsigned char USART_Rx(){
	while(!(UCSRA & (1<<RXC)));
	return UDR;
}

ISR(USART_RXC_vect){
	while(!(UCSRA & (1<<RXC)));
	rxdata = UDR;
	if(rxdata == 'D' && dispdata ==0){dispdata = 1; UCSRB &= ~(1<<RXCIE);}
	if(rxdata == 'P' && progdata ==0){progdata = 1; UCSRB &= ~(1<<RXCIE);}
}


void EEOpen()
{
	//Set up TWI Module
	TWBR = 5;
	TWSR &= (~((1<<TWPS1)|(1<<TWPS0)));
}
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

unsigned char EEWriteByte(unsigned int address,unsigned char data)
{
	do
	{
		//Put Start Condition on TWI Bus
		TWCR=(1<<TWINT)|(1<<TWSTA)|(1<<TWEN);

		//Poll Till Done
		while(!(TWCR & (1<<TWINT)));

		//Check status
		if((TWSR & 0xF8) != 0x08)
			return FALSE;

		//Now write SLA+W
		//EEPROM @ 00h
		TWDR=0b10100000;	

		//Initiate Transfer
		TWCR=(1<<TWINT)|(1<<TWEN);

		//Poll Till Done
		while(!(TWCR & (1<<TWINT)));
	
	}while((TWSR & 0xF8) != 0x18);
		

	//Now write ADDRH
	TWDR=(address>>8);

	//Initiate Transfer
	TWCR=(1<<TWINT)|(1<<TWEN);

	//Poll Till Done
	while(!(TWCR & (1<<TWINT)));

	//Check status
	if((TWSR & 0xF8) != 0x28)
		return FALSE;

	//Now write ADDRL
	TWDR=(address);

	//Initiate Transfer
	TWCR=(1<<TWINT)|(1<<TWEN);

	//Poll Till Done
	while(!(TWCR & (1<<TWINT)));

	//Check status
	if((TWSR & 0xF8) != 0x28)
		return FALSE;

	//Now write DATA
	TWDR=(data);

	//Initiate Transfer
	TWCR=(1<<TWINT)|(1<<TWEN);

	//Poll Till Done
	while(!(TWCR & (1<<TWINT)));

	//Check status
	if((TWSR & 0xF8) != 0x28)
		return FALSE;

	//Put Stop Condition on bus
	TWCR=(1<<TWINT)|(1<<TWEN)|(1<<TWSTO);
	
	//Wait for STOP to finish
	while(TWCR & (1<<TWSTO));

	//Wait untill Writing is complete
	_delay_ms(12);

	//Return TRUE
	return TRUE;

}
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

unsigned char EEReadByte(unsigned int address)
{
	unsigned char data;

	//Initiate a Dummy Write Sequence to start Random Read
	do
	{
		//Put Start Condition on TWI Bus
		TWCR=(1<<TWINT)|(1<<TWSTA)|(1<<TWEN);

		//Poll Till Done
		while(!(TWCR & (1<<TWINT)));

		//Check status
		if((TWSR & 0xF8) != 0x08)
			return FALSE;

		//Now write SLA+W
		//EEPROM @ 00h
		TWDR=0b10100000;	

		//Initiate Transfer
		TWCR=(1<<TWINT)|(1<<TWEN);

		//Poll Till Done
		while(!(TWCR & (1<<TWINT)));
	
	}while((TWSR & 0xF8) != 0x18);
		

	//Now write ADDRH
	TWDR=(address>>8);

	//Initiate Transfer
	TWCR=(1<<TWINT)|(1<<TWEN);

	//Poll Till Done
	while(!(TWCR & (1<<TWINT)));

	//Check status
	if((TWSR & 0xF8) != 0x28)
		return FALSE;

	//Now write ADDRL
	TWDR=(address);

	//Initiate Transfer
	TWCR=(1<<TWINT)|(1<<TWEN);

	//Poll Till Done
	while(!(TWCR & (1<<TWINT)));

	//Check status
	if((TWSR & 0xF8) != 0x28)
		return FALSE;

	//*************************DUMMY WRITE SEQUENCE END **********************


	
	//Put Start Condition on TWI Bus
	TWCR=(1<<TWINT)|(1<<TWSTA)|(1<<TWEN);

	//Poll Till Done
	while(!(TWCR & (1<<TWINT)));

	//Check status
	if((TWSR & 0xF8) != 0x10)
		return FALSE;

	//Now write SLA+R
	//EEPROM @ 00h
	TWDR=0b10100001;	

	//Initiate Transfer
	TWCR=(1<<TWINT)|(1<<TWEN);

	//Poll Till Done
	while(!(TWCR & (1<<TWINT)));

	//Check status
	if((TWSR & 0xF8) != 0x40)
		return FALSE;

	//Now enable Reception of data by clearing TWINT
	TWCR=(1<<TWINT)|(1<<TWEN);

	//Wait till done
	while(!(TWCR & (1<<TWINT)));

	//Check status
	if((TWSR & 0xF8) != 0x58)
		return FALSE;

	//Read the data
	data=TWDR;

	//Put Stop Condition on bus
	TWCR=(1<<TWINT)|(1<<TWEN)|(1<<TWSTO);
	
	//Wait for STOP to finish
	while(TWCR & (1<<TWSTO));

	//Return TRUE
	return data;
}

////////////////////////////////////////////////////////////////////////////////////////////////////
	





