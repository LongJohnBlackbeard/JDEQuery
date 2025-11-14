using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0590 - .
/// </summary>
public class F76B0590 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CHJOBS.
        /// </summary>
        public const string CHJOBS = "CHJOBS";

        /// <summary>
        /// CHAID.
        /// </summary>
        public const string CHAID = "CHAID";

        /// <summary>
        /// CHCO.
        /// </summary>
        public const string CHCO = "CHCO";

        /// <summary>
        /// CHMCU.
        /// </summary>
        public const string CHMCU = "CHMCU";

        /// <summary>
        /// CHOBJ.
        /// </summary>
        public const string CHOBJ = "CHOBJ";

        /// <summary>
        /// CHSUB.
        /// </summary>
        public const string CHSUB = "CHSUB";

        /// <summary>
        /// CHB76ACNI.
        /// </summary>
        public const string CHB76ACNI = "CHB76ACNI";

        /// <summary>
        /// CHB76ATI.
        /// </summary>
        public const string CHB76ATI = "CHB76ATI";

        /// <summary>
        /// CHDL01.
        /// </summary>
        public const string CHDL01 = "CHDL01";

        /// <summary>
        /// CHLDA.
        /// </summary>
        public const string CHLDA = "CHLDA";

        /// <summary>
        /// CHPEC.
        /// </summary>
        public const string CHPEC = "CHPEC";

        /// <summary>
        /// CHPID.
        /// </summary>
        public const string CHPID = "CHPID";

        /// <summary>
        /// CHUSER.
        /// </summary>
        public const string CHUSER = "CHUSER";

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
    }

    /// <inheritdoc />
    public override string TableName => "F76B0590";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CHJOBS", "CHJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CHAID", "CHAID", JdeDataType.String, 16, true, true),
        new JdeField("CHCO", "CHCO", JdeDataType.String, 10),
        new JdeField("CHMCU", "CHMCU", JdeDataType.String, 24),
        new JdeField("CHOBJ", "CHOBJ", JdeDataType.String, 12),
        new JdeField("CHSUB", "CHSUB", JdeDataType.String, 16),
        new JdeField("CHB76ACNI", "CHB76ACNI", JdeDataType.String, 4),
        new JdeField("CHB76ATI", "CHB76ATI", JdeDataType.String, 2),
        new JdeField("CHDL01", "CHDL01", JdeDataType.String, 60),
        new JdeField("CHLDA", "CHLDA", JdeDataType.String, 2),
        new JdeField("CHPEC", "CHPEC", JdeDataType.String, 2),
        new JdeField("CHPID", "CHPID", JdeDataType.String, 20),
        new JdeField("CHUSER", "CHUSER", JdeDataType.String, 20),
        new JdeField("CHJOBN", "CHJOBN", JdeDataType.String, 20),
        new JdeField("CHUPMJ", "CHUPMJ", JdeDataType.Numeric),
        new JdeField("CHUPMT", "CHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0590_0", "Primary Key on CHJOBS, CHAID", new[] { "CHJOBS", "CHAID" }, isUnique: true, isPrimaryKey: true)
    };
}
