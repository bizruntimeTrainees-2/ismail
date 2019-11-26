const posts = [
	{title: 'post one',body: 'this is post one'},
	{title: 'post two',body: 'this is post two'}
	];

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
		setTimeout( ()=> {
			 posts.push(post);
		},1000);
	}
	
	createPost({titile: 'Post Three', body: 'This is post three'},getPosts);
