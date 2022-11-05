float width = 1000; 
float length = 120;
float area = 0.0;
float price = 0.0;

void setup()
{
  Serial.begin(9600);
}

void loop()
{
  
  
  area = width * length;
  price = area * 100000;
  
  Serial.println(area);
  Serial.println(price);
  delay(1000);
}
