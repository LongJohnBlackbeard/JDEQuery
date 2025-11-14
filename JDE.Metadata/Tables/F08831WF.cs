using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08831WF - .
/// </summary>
public class F08831WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YSMNAME.
        /// </summary>
        public const string YSMNAME = "YSMNAME";

        /// <summary>
        /// YSRWTYP.
        /// </summary>
        public const string YSRWTYP = "YSRWTYP";

        /// <summary>
        /// YSAN8.
        /// </summary>
        public const string YSAN8 = "YSAN8";

        /// <summary>
        /// YSTRS.
        /// </summary>
        public const string YSTRS = "YSTRS";

        /// <summary>
        /// YSMOWNR.
        /// </summary>
        public const string YSMOWNR = "YSMOWNR";

        /// <summary>
        /// YSIDL01.
        /// </summary>
        public const string YSIDL01 = "YSIDL01";

        /// <summary>
        /// YSJTCHG.
        /// </summary>
        public const string YSJTCHG = "YSJTCHG";

        /// <summary>
        /// YSACTEL.
        /// </summary>
        public const string YSACTEL = "YSACTEL";

        /// <summary>
        /// YSMODEL.
        /// </summary>
        public const string YSMODEL = "YSMODEL";

        /// <summary>
        /// YSPRORFT.
        /// </summary>
        public const string YSPRORFT = "YSPRORFT";

        /// <summary>
        /// YSGLLOR.
        /// </summary>
        public const string YSGLLOR = "YSGLLOR";

        /// <summary>
        /// YSGLHR.
        /// </summary>
        public const string YSGLHR = "YSGLHR";

        /// <summary>
        /// YSGLIM.
        /// </summary>
        public const string YSGLIM = "YSGLIM";

        /// <summary>
        /// YSINCRA.
        /// </summary>
        public const string YSINCRA = "YSINCRA";

        /// <summary>
        /// YSINCRAM.
        /// </summary>
        public const string YSINCRAM = "YSINCRAM";

        /// <summary>
        /// YSPRORA.
        /// </summary>
        public const string YSPRORA = "YSPRORA";

        /// <summary>
        /// YSPRORT.
        /// </summary>
        public const string YSPRORT = "YSPRORT";

        /// <summary>
        /// YSINCRO.
        /// </summary>
        public const string YSINCRO = "YSINCRO";

        /// <summary>
        /// YSPREVI.
        /// </summary>
        public const string YSPREVI = "YSPREVI";

        /// <summary>
        /// YSPRINC.
        /// </summary>
        public const string YSPRINC = "YSPRINC";

        /// <summary>
        /// YSPRPRA.
        /// </summary>
        public const string YSPRPRA = "YSPRPRA";

        /// <summary>
        /// YSPRPRO.
        /// </summary>
        public const string YSPRPRO = "YSPRPRO";

        /// <summary>
        /// YSALBA.
        /// </summary>
        public const string YSALBA = "YSALBA";

        /// <summary>
        /// YSUSER.
        /// </summary>
        public const string YSUSER = "YSUSER";

        /// <summary>
        /// YSPID.
        /// </summary>
        public const string YSPID = "YSPID";

        /// <summary>
        /// YSUPMJ.
        /// </summary>
        public const string YSUPMJ = "YSUPMJ";

        /// <summary>
        /// YSUPMT.
        /// </summary>
        public const string YSUPMT = "YSUPMT";

        /// <summary>
        /// YSJOBN.
        /// </summary>
        public const string YSJOBN = "YSJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08831WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YSMNAME", "YSMNAME", JdeDataType.String, 20, true, true),
        new JdeField("YSRWTYP", "YSRWTYP", JdeDataType.String, 2, true, true),
        new JdeField("YSAN8", "YSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YSTRS", "YSTRS", JdeDataType.String, 6, true, true),
        new JdeField("YSMOWNR", "YSMOWNR", JdeDataType.Numeric, null, true, true),
        new JdeField("YSIDL01", "YSIDL01", JdeDataType.String, 60),
        new JdeField("YSJTCHG", "YSJTCHG", JdeDataType.String, 2),
        new JdeField("YSACTEL", "YSACTEL", JdeDataType.String, 2),
        new JdeField("YSMODEL", "YSMODEL", JdeDataType.String, 2),
        new JdeField("YSPRORFT", "YSPRORFT", JdeDataType.Numeric),
        new JdeField("YSGLLOR", "YSGLLOR", JdeDataType.Numeric),
        new JdeField("YSGLHR", "YSGLHR", JdeDataType.Numeric),
        new JdeField("YSGLIM", "YSGLIM", JdeDataType.String, 2),
        new JdeField("YSINCRA", "YSINCRA", JdeDataType.Numeric),
        new JdeField("YSINCRAM", "YSINCRAM", JdeDataType.Numeric),
        new JdeField("YSPRORA", "YSPRORA", JdeDataType.Numeric),
        new JdeField("YSPRORT", "YSPRORT", JdeDataType.Numeric),
        new JdeField("YSINCRO", "YSINCRO", JdeDataType.String, 2),
        new JdeField("YSPREVI", "YSPREVI", JdeDataType.Numeric),
        new JdeField("YSPRINC", "YSPRINC", JdeDataType.Numeric),
        new JdeField("YSPRPRA", "YSPRPRA", JdeDataType.Numeric),
        new JdeField("YSPRPRO", "YSPRPRO", JdeDataType.Numeric),
        new JdeField("YSALBA", "YSALBA", JdeDataType.Numeric),
        new JdeField("YSUSER", "YSUSER", JdeDataType.String, 20),
        new JdeField("YSPID", "YSPID", JdeDataType.String, 20),
        new JdeField("YSUPMJ", "YSUPMJ", JdeDataType.Numeric),
        new JdeField("YSUPMT", "YSUPMT", JdeDataType.Numeric),
        new JdeField("YSJOBN", "YSJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08831WF_0", "Primary Key on YSMNAME, YSRWTYP, YSAN8, YSTRS, YSMOWNR", new[] { "YSMNAME", "YSRWTYP", "YSAN8", "YSTRS", "YSMOWNR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08831WF_2", "Index on YSMNAME, YSRWTYP, YSAN8, YSTRS", new[] { "YSMNAME", "YSRWTYP", "YSAN8", "YSTRS" })
    };
}
