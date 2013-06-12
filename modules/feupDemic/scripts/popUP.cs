function createPopup(%region,%kind){
	%obj=new Sprite(){
		class="popUP";
	};

	%obj.Position=feupDemic[%region.id].Position;
	%obj.create;

}