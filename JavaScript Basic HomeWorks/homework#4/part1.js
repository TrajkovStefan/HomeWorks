function tellStory(Name,mood,activity){
    if(typeof(Name&&mood&&activity)==="string"){
        alert(`This is ${Name}. ${Name} is a nice person. Today they are ${mood}. They are ${activity} all day. The end.`);
    }
    else{
        alert("Enter string");
    }
}

tellStory("Stefan","good","studied");

