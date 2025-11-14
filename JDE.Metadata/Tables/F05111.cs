using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05111 - .
/// </summary>
public class F05111 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTAN8.
        /// </summary>
        public const string CTAN8 = "CTAN8";

        /// <summary>
        /// CTCMPC.
        /// </summary>
        public const string CTCMPC = "CTCMPC";

        /// <summary>
        /// CTCUCD.
        /// </summary>
        public const string CTCUCD = "CTCUCD";

        /// <summary>
        /// CTINEC.
        /// </summary>
        public const string CTINEC = "CTINEC";

        /// <summary>
        /// CTSEQ.
        /// </summary>
        public const string CTSEQ = "CTSEQ";

        /// <summary>
        /// CTTRSD.
        /// </summary>
        public const string CTTRSD = "CTTRSD";

        /// <summary>
        /// CTTREN.
        /// </summary>
        public const string CTTREN = "CTTREN";

        /// <summary>
        /// CTGRD.
        /// </summary>
        public const string CTGRD = "CTGRD";

        /// <summary>
        /// CTLCRM.
        /// </summary>
        public const string CTLCRM = "CTLCRM";

        /// <summary>
        /// CTDLTY.
        /// </summary>
        public const string CTDLTY = "CTDLTY";

        /// <summary>
        /// CTUNT.
        /// </summary>
        public const string CTUNT = "CTUNT";

        /// <summary>
        /// CTCUCT.
        /// </summary>
        public const string CTCUCT = "CTCUCT";

        /// <summary>
        /// CTRESN.
        /// </summary>
        public const string CTRESN = "CTRESN";

        /// <summary>
        /// CTUSER.
        /// </summary>
        public const string CTUSER = "CTUSER";

        /// <summary>
        /// CTPID.
        /// </summary>
        public const string CTPID = "CTPID";

        /// <summary>
        /// CTJOBN.
        /// </summary>
        public const string CTJOBN = "CTJOBN";

        /// <summary>
        /// CTUPMJ.
        /// </summary>
        public const string CTUPMJ = "CTUPMJ";

        /// <summary>
        /// CTUPMT.
        /// </summary>
        public const string CTUPMT = "CTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05111";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTAN8", "CTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CTCMPC", "CTCMPC", JdeDataType.String, 20, true, true),
        new JdeField("CTCUCD", "CTCUCD", JdeDataType.String, 20),
        new JdeField("CTINEC", "CTINEC", JdeDataType.String, 20),
        new JdeField("CTSEQ", "CTSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CTTRSD", "CTTRSD", JdeDataType.Numeric),
        new JdeField("CTTREN", "CTTREN", JdeDataType.Numeric),
        new JdeField("CTGRD", "CTGRD", JdeDataType.String, 6),
        new JdeField("CTLCRM", "CTLCRM", JdeDataType.String, 20),
        new JdeField("CTDLTY", "CTDLTY", JdeDataType.String, 20),
        new JdeField("CTUNT", "CTUNT", JdeDataType.Numeric),
        new JdeField("CTCUCT", "CTCUCT", JdeDataType.Numeric),
        new JdeField("CTRESN", "CTRESN", JdeDataType.String, 6),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20),
        new JdeField("CTJOBN", "CTJOBN", JdeDataType.String, 20),
        new JdeField("CTUPMJ", "CTUPMJ", JdeDataType.Numeric),
        new JdeField("CTUPMT", "CTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05111_0", "Primary Key on CTAN8, CTCMPC, CTSEQ", new[] { "CTAN8", "CTCMPC", "CTSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F05111_2", "Index on CTCMPC, CTAN8, CTCUCD, CTINEC, CTSEQ", new[] { "CTCMPC", "CTAN8", "CTCUCD", "CTINEC", "CTSEQ" }),
        new JdeIndex("F05111_3", "Index on CTINEC, CTCUCD", new[] { "CTINEC", "CTCUCD" })
    };
}
