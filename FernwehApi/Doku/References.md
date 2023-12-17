# Find Place 

  // https://maps.googleapis.com/maps/api/place/findplacefromtext/output?parameters
  // https://maps.googleapis.com/maps/api/place/findplacefromtext/json?cafesleipzig&textquery

Cafes in Leipzig
Should be then

https://maps.googleapis.com/maps/api/place/findplacefromtext/json
  ?fields=formatted_address%2Cname%2Crating%2Copening_hours%2Cgeometry
  &input=Cafes%20In%20Leipzig
  &inputtype=textquery
  &key=MY_KEY

"https://maps.googleapis.com/maps/api/place/findplacefromtext/json
  &fields=formatted_address,name,rating,opening_hours,geometry
  &input=Cafes%20In%20Leipzig
  &inputtype=textquery
  &key="


## Requests:
https://maps.googleapis.com/maps/api/place/findplacefromtext/json
  ?fields=formatted_address%2Cname%2Crating%2Copening_hours%2Cgeometry
  &input=Museum%20of%20Contemporary%20Art%20Australia
  &inputtype=textquery
  &key=YOUR_API_KEY

## Response:
{
  "candidates":
    [
      {
        "formatted_address": "140 George St, The Rocks NSW 2000, Australia",
        "geometry":
          {
            "location": { "lat": -33.8599358, "lng": 151.2090295 },
            "viewport":
              {
                "northeast":
                  { "lat": -33.85824377010728, "lng": 151.2104386798927 },
                "southwest":
                  { "lat": -33.86094342989272, "lng": 151.2077390201073 },
              },
          },
        "name": "Museum of Contemporary Art Australia",
        "opening_hours": { "open_now": false },
        "rating": 4.4,
      },
    ],
  "status": "OK",
}

https://maps.googleapis.com/maps/api/place/findplacefromtext/json
  ?fields=formatted_address%2Cname%2Crating%2Copening_hours%2Cgeometry
  &input=mongolian
  &inputtype=textquery
  &locationbias=circle%3A2000%4047.6918452%2C-122.2226413
  &key=YOUR_API_KEY


https://maps.googleapis.com/maps/api/place/findplacefromtext/json
  ?input=%2B16502530000
  &inputtype=phonenumber
  &key=YOUR_API_KEY
