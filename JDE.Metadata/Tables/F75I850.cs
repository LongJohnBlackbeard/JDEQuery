using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I850 - .
/// </summary>
public class F75I850 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CLUKID.
        /// </summary>
        public const string CLUKID = "CLUKID";

        /// <summary>
        /// CLDOC.
        /// </summary>
        public const string CLDOC = "CLDOC";

        /// <summary>
        /// CLKCO.
        /// </summary>
        public const string CLKCO = "CLKCO";

        /// <summary>
        /// CLDCT.
        /// </summary>
        public const string CLDCT = "CLDCT";

        /// <summary>
        /// CLJELN.
        /// </summary>
        public const string CLJELN = "CLJELN";

        /// <summary>
        /// CLAN8.
        /// </summary>
        public const string CLAN8 = "CLAN8";

        /// <summary>
        /// CLPYID.
        /// </summary>
        public const string CLPYID = "CLPYID";

        /// <summary>
        /// CLPAAP.
        /// </summary>
        public const string CLPAAP = "CLPAAP";

        /// <summary>
        /// CLDOCM.
        /// </summary>
        public const string CLDOCM = "CLDOCM";

        /// <summary>
        /// CLDMTJ.
        /// </summary>
        public const string CLDMTJ = "CLDMTJ";

        /// <summary>
        /// CLI75GSTU.
        /// </summary>
        public const string CLI75GSTU = "CLI75GSTU";

        /// <summary>
        /// CLPN.
        /// </summary>
        public const string CLPN = "CLPN";

        /// <summary>
        /// CLYRM.
        /// </summary>
        public const string CLYRM = "CLYRM";

        /// <summary>
        /// CLI75REMK.
        /// </summary>
        public const string CLI75REMK = "CLI75REMK";

        /// <summary>
        /// CLI75CGSTA.
        /// </summary>
        public const string CLI75CGSTA = "CLI75CGSTA";

        /// <summary>
        /// CLI75SGSTA.
        /// </summary>
        public const string CLI75SGSTA = "CLI75SGSTA";

        /// <summary>
        /// CLI75IGSTA.
        /// </summary>
        public const string CLI75IGSTA = "CLI75IGSTA";

        /// <summary>
        /// CLI75CESSA.
        /// </summary>
        public const string CLI75CESSA = "CLI75CESSA";

        /// <summary>
        /// CLI75PRFL.
        /// </summary>
        public const string CLI75PRFL = "CLI75PRFL";

        /// <summary>
        /// CLI75ATX1A.
        /// </summary>
        public const string CLI75ATX1A = "CLI75ATX1A";

        /// <summary>
        /// CLI75ATX2A.
        /// </summary>
        public const string CLI75ATX2A = "CLI75ATX2A";

        /// <summary>
        /// CLI75ATX3A.
        /// </summary>
        public const string CLI75ATX3A = "CLI75ATX3A";

        /// <summary>
        /// CLI75AT4A.
        /// </summary>
        public const string CLI75AT4A = "CLI75AT4A";

        /// <summary>
        /// CLUSER.
        /// </summary>
        public const string CLUSER = "CLUSER";

        /// <summary>
        /// CLPID.
        /// </summary>
        public const string CLPID = "CLPID";

        /// <summary>
        /// CLJOBN.
        /// </summary>
        public const string CLJOBN = "CLJOBN";

        /// <summary>
        /// CLUPMJ.
        /// </summary>
        public const string CLUPMJ = "CLUPMJ";

        /// <summary>
        /// CLUPMT.
        /// </summary>
        public const string CLUPMT = "CLUPMT";

        /// <summary>
        /// CLYFUTDT1.
        /// </summary>
        public const string CLYFUTDT1 = "CLYFUTDT1";

        /// <summary>
        /// CLFUT6.
        /// </summary>
        public const string CLFUT6 = "CLFUT6";

        /// <summary>
        /// CLYT04.
        /// </summary>
        public const string CLYT04 = "CLYT04";

        /// <summary>
        /// CLYFLAG.
        /// </summary>
        public const string CLYFLAG = "CLYFLAG";

        /// <summary>
        /// CLYNUM1.
        /// </summary>
        public const string CLYNUM1 = "CLYNUM1";

        /// <summary>
        /// CLICU.
        /// </summary>
        public const string CLICU = "CLICU";

        /// <summary>
        /// CLICUT.
        /// </summary>
        public const string CLICUT = "CLICUT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I850";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CLUKID", "CLUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("CLDOC", "CLDOC", JdeDataType.Numeric),
        new JdeField("CLKCO", "CLKCO", JdeDataType.String, 10),
        new JdeField("CLDCT", "CLDCT", JdeDataType.String, 4),
        new JdeField("CLJELN", "CLJELN", JdeDataType.Numeric),
        new JdeField("CLAN8", "CLAN8", JdeDataType.Numeric),
        new JdeField("CLPYID", "CLPYID", JdeDataType.Numeric),
        new JdeField("CLPAAP", "CLPAAP", JdeDataType.Numeric),
        new JdeField("CLDOCM", "CLDOCM", JdeDataType.Numeric),
        new JdeField("CLDMTJ", "CLDMTJ", JdeDataType.Numeric),
        new JdeField("CLI75GSTU", "CLI75GSTU", JdeDataType.Numeric),
        new JdeField("CLPN", "CLPN", JdeDataType.Numeric),
        new JdeField("CLYRM", "CLYRM", JdeDataType.Numeric),
        new JdeField("CLI75REMK", "CLI75REMK", JdeDataType.String, 60),
        new JdeField("CLI75CGSTA", "CLI75CGSTA", JdeDataType.Numeric),
        new JdeField("CLI75SGSTA", "CLI75SGSTA", JdeDataType.Numeric),
        new JdeField("CLI75IGSTA", "CLI75IGSTA", JdeDataType.Numeric),
        new JdeField("CLI75CESSA", "CLI75CESSA", JdeDataType.Numeric),
        new JdeField("CLI75PRFL", "CLI75PRFL", JdeDataType.String, 2),
        new JdeField("CLI75ATX1A", "CLI75ATX1A", JdeDataType.Numeric),
        new JdeField("CLI75ATX2A", "CLI75ATX2A", JdeDataType.Numeric),
        new JdeField("CLI75ATX3A", "CLI75ATX3A", JdeDataType.Numeric),
        new JdeField("CLI75AT4A", "CLI75AT4A", JdeDataType.Numeric),
        new JdeField("CLUSER", "CLUSER", JdeDataType.String, 20),
        new JdeField("CLPID", "CLPID", JdeDataType.String, 20),
        new JdeField("CLJOBN", "CLJOBN", JdeDataType.String, 20),
        new JdeField("CLUPMJ", "CLUPMJ", JdeDataType.Numeric),
        new JdeField("CLUPMT", "CLUPMT", JdeDataType.Numeric),
        new JdeField("CLYFUTDT1", "CLYFUTDT1", JdeDataType.Numeric),
        new JdeField("CLFUT6", "CLFUT6", JdeDataType.String, 60),
        new JdeField("CLYT04", "CLYT04", JdeDataType.String, 2),
        new JdeField("CLYFLAG", "CLYFLAG", JdeDataType.String, 2),
        new JdeField("CLYNUM1", "CLYNUM1", JdeDataType.Numeric),
        new JdeField("CLICU", "CLICU", JdeDataType.Numeric),
        new JdeField("CLICUT", "CLICUT", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I850_0", "Primary Key on CLUKID", new[] { "CLUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I850_2", "Index on CLKCO, CLDCT, CLDOC, CLJELN, CLPYID, CLI75PRFL", new[] { "CLKCO", "CLDCT", "CLDOC", "CLJELN", "CLPYID", "CLI75PRFL" }),
        new JdeIndex("F75I850_3", "Index on CLICU, CLICUT", new[] { "CLICU", "CLICUT" })
    };
}
