				import worker, * as OTHER_EXPORTS from "C:\\Users\\arsen\\Documents\\Work\\Personal\\GitHub README\\src\\worker.ts";
				import * as __MIDDLEWARE_0__ from "C:\\Users\\arsen\\Documents\\Work\\Personal\\GitHub README\\node_modules\\.pnpm\\wrangler@3.17.1\\node_modules\\wrangler\\templates\\middleware\\middleware-miniflare3-json-error.ts";
				const envWrappers = [__MIDDLEWARE_0__.wrap].filter(Boolean);
				const facade = {
					...worker,
					envWrappers,
					middleware: [
						__MIDDLEWARE_0__.default,
            ...(worker.middleware ? worker.middleware : []),
					].filter(Boolean)
				}
				export * from "C:\\Users\\arsen\\Documents\\Work\\Personal\\GitHub README\\src\\worker.ts";

				const maskDurableObjectDefinition = (cls) =>
					class extends cls {
						constructor(state, env) {
							let wrappedEnv = env
							for (const wrapFn of envWrappers) {
								wrappedEnv = wrapFn(wrappedEnv)
							}
							super(state, wrappedEnv);
						}
					};
				

				export default facade;