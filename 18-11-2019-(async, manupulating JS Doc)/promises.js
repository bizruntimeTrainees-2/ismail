function getPosts(){
		setTimeout( () => {
			let output ='';
			post.foreach( (post, index) => {
				output +=' ${post.titile}';
			});
      document.getElementById("call").innerHTML = output;
		}, 1000);
	}
	function 	createPost(post) {
		return new Promise((resolve, reject) => {
		    setTimeout( ()=> {
			 posts.push(post);
			 const error=true;
			 if(!error) {
				 resolve();
			 }
			 else{
				 reject('error: something went wrong');
			 }
		}, 2000);
	});
	}
createPost( {title : 'post three', body:'this is post three'} ).then(getPosts).catch(err => console.log(err));


/*
//Promises.all
const promise1 = Promise.resolve('hello');
const promise2 = 10;
const promise3 = new Promise((resolve, reject) => setTimeout(resolve, 2000, 'Goodbye'));

Promise.all([promise1, promise2, promise3]).then(values => console.log(values));
*/

/*
//   async/await
async function init(){
	await createPost( {title: 'Post three', body: 'this is post three'} );

	getPosts();
}
init();
*/