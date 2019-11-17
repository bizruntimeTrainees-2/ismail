function init(){
document.cookie ="text1= Hello";
document.cookie ="text2= To";
}
function cookieValue(){

	if (document.cookie.split(';').filter((item) => item.trim().startsWith('reader=')).length) {
 alert(   "The cookie reader exists ")
}
}
function resetOnce(){
	document.cookie ="text4= World";
}
