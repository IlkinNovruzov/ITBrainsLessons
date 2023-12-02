var e = document.getElementById('list')
const url = 'https://api.aladhan.com/v1/calendarByCity/2023/12?city=Baku&country=Azerbaijan%20Kingdom&method=2'
fetch(url)
    .then(res => {
        if (res.ok) {
            console.log('Success')
        } else {
            console.log('Not Success')
        }
        return res.json();
    }).then(item => {
        item.data.forEach(element => {
            console.log(element)

            e.innerHTML += `
        <ul>
        <li>${element.date.gregorian.date}</li>
        <li>${element.date.gregorian.weekday.en}</li>
        <li>${element.timings.Midnight}</li>
        <li>${element.timings.Sunrise}</li>
        <li>${element.timings.Sunset}</li>
        </ul>
              `
        });
    })
    .catch(error => console.log('Error'));