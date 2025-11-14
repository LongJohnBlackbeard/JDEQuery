using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F054111 - .
/// </summary>
public class F054111 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CHAN8.
        /// </summary>
        public const string CHAN8 = "CHAN8";

        /// <summary>
        /// CHIDLN.
        /// </summary>
        public const string CHIDLN = "CHIDLN";

        /// <summary>
        /// CHSLNM.
        /// </summary>
        public const string CHSLNM = "CHSLNM";

        /// <summary>
        /// CHMLNM.
        /// </summary>
        public const string CHMLNM = "CHMLNM";

        /// <summary>
        /// CHGNNM.
        /// </summary>
        public const string CHGNNM = "CHGNNM";

        /// <summary>
        /// CHIMN.
        /// </summary>
        public const string CHIMN = "CHIMN";

        /// <summary>
        /// CHSRNM.
        /// </summary>
        public const string CHSRNM = "CHSRNM";

        /// <summary>
        /// CHADD1.
        /// </summary>
        public const string CHADD1 = "CHADD1";

        /// <summary>
        /// CHCTY1.
        /// </summary>
        public const string CHCTY1 = "CHCTY1";

        /// <summary>
        /// CHADDS.
        /// </summary>
        public const string CHADDS = "CHADDS";

        /// <summary>
        /// CHADDZ.
        /// </summary>
        public const string CHADDZ = "CHADDZ";

        /// <summary>
        /// CHCTR.
        /// </summary>
        public const string CHCTR = "CHCTR";

        /// <summary>
        /// CHTYC.
        /// </summary>
        public const string CHTYC = "CHTYC";

        /// <summary>
        /// CHATTL.
        /// </summary>
        public const string CHATTL = "CHATTL";

        /// <summary>
        /// CHDSS5.
        /// </summary>
        public const string CHDSS5 = "CHDSS5";

        /// <summary>
        /// CHREM1.
        /// </summary>
        public const string CHREM1 = "CHREM1";

        /// <summary>
        /// CHUSER.
        /// </summary>
        public const string CHUSER = "CHUSER";

        /// <summary>
        /// CHPID.
        /// </summary>
        public const string CHPID = "CHPID";

        /// <summary>
        /// CHJOBN.
        /// </summary>
        public const string CHJOBN = "CHJOBN";

        /// <summary>
        /// CHUPMJ.
        /// </summary>
        public const string CHUPMJ = "CHUPMJ";

        /// <summary>
        /// CHUPMT.
        /// </summary>
        public const string CHUPMT = "CHUPMT";

        /// <summary>
        /// CHESIGN.
        /// </summary>
        public const string CHESIGN = "CHESIGN";

        /// <summary>
        /// CHMUMJ.
        /// </summary>
        public const string CHMUMJ = "CHMUMJ";

        /// <summary>
        /// CHMUMT.
        /// </summary>
        public const string CHMUMT = "CHMUMT";

        /// <summary>
        /// CHUPID.
        /// </summary>
        public const string CHUPID = "CHUPID";
    }

    /// <inheritdoc />
    public override string TableName => "F054111";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CHAN8", "CHAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CHIDLN", "CHIDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("CHSLNM", "CHSLNM", JdeDataType.String, 80),
        new JdeField("CHMLNM", "CHMLNM", JdeDataType.String, 80),
        new JdeField("CHGNNM", "CHGNNM", JdeDataType.String, 50),
        new JdeField("CHIMN", "CHIMN", JdeDataType.String, 2),
        new JdeField("CHSRNM", "CHSRNM", JdeDataType.String, 50),
        new JdeField("CHADD1", "CHADD1", JdeDataType.String, 80),
        new JdeField("CHCTY1", "CHCTY1", JdeDataType.String, 50),
        new JdeField("CHADDS", "CHADDS", JdeDataType.String, 6),
        new JdeField("CHADDZ", "CHADDZ", JdeDataType.String, 24),
        new JdeField("CHCTR", "CHCTR", JdeDataType.String, 6),
        new JdeField("CHTYC", "CHTYC", JdeDataType.String, 2),
        new JdeField("CHATTL", "CHATTL", JdeDataType.String, 80),
        new JdeField("CHDSS5", "CHDSS5", JdeDataType.Numeric),
        new JdeField("CHREM1", "CHREM1", JdeDataType.String, 80),
        new JdeField("CHUSER", "CHUSER", JdeDataType.String, 20),
        new JdeField("CHPID", "CHPID", JdeDataType.String, 20),
        new JdeField("CHJOBN", "CHJOBN", JdeDataType.String, 20),
        new JdeField("CHUPMJ", "CHUPMJ", JdeDataType.Numeric),
        new JdeField("CHUPMT", "CHUPMT", JdeDataType.Numeric),
        new JdeField("CHESIGN", "CHESIGN", JdeDataType.String, 32, true, true),
        new JdeField("CHMUMJ", "CHMUMJ", JdeDataType.Numeric),
        new JdeField("CHMUMT", "CHMUMT", JdeDataType.Numeric),
        new JdeField("CHUPID", "CHUPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F054111_0", "Primary Key on CHAN8, CHIDLN, CHESIGN", new[] { "CHAN8", "CHIDLN", "CHESIGN" }, isUnique: true, isPrimaryKey: true)
    };
}
