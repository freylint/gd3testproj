mod dbg;

use gdnative::prelude::*;


fn init(handle: InitHandle) {
    handle.add_class::<dbg::HelloWorld>();
}

godot_init!(init);

#[cfg(test)]
mod tests {
    #[test]
    fn it_works() {
        let result = 2 + 2;
        assert_eq!(result, 4);
    }
}
