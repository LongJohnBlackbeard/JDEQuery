using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49004 - .
/// </summary>
public class F49004 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTMCU.
        /// </summary>
        public const string CTMCU = "CTMCU";

        /// <summary>
        /// CTMOT.
        /// </summary>
        public const string CTMOT = "CTMOT";

        /// <summary>
        /// CTJBCD.
        /// </summary>
        public const string CTJBCD = "CTJBCD";

        /// <summary>
        /// CTRLTR.
        /// </summary>
        public const string CTRLTR = "CTRLTR";

        /// <summary>
        /// CTRLTV.
        /// </summary>
        public const string CTRLTV = "CTRLTV";

        /// <summary>
        /// CTCMNF.
        /// </summary>
        public const string CTCMNF = "CTCMNF";

        /// <summary>
        /// CTLRFG.
        /// </summary>
        public const string CTLRFG = "CTLRFG";

        /// <summary>
        /// CTBNFG.
        /// </summary>
        public const string CTBNFG = "CTBNFG";

        /// <summary>
        /// CTPCSD.
        /// </summary>
        public const string CTPCSD = "CTPCSD";

        /// <summary>
        /// CTGLC.
        /// </summary>
        public const string CTGLC = "CTGLC";

        /// <summary>
        /// CTVTYP.
        /// </summary>
        public const string CTVTYP = "CTVTYP";

        /// <summary>
        /// CTLDTY.
        /// </summary>
        public const string CTLDTY = "CTLDTY";

        /// <summary>
        /// CTLTDL.
        /// </summary>
        public const string CTLTDL = "CTLTDL";

        /// <summary>
        /// CTURCD.
        /// </summary>
        public const string CTURCD = "CTURCD";

        /// <summary>
        /// CTURDT.
        /// </summary>
        public const string CTURDT = "CTURDT";

        /// <summary>
        /// CTURAT.
        /// </summary>
        public const string CTURAT = "CTURAT";

        /// <summary>
        /// CTURAB.
        /// </summary>
        public const string CTURAB = "CTURAB";

        /// <summary>
        /// CTURRF.
        /// </summary>
        public const string CTURRF = "CTURRF";

        /// <summary>
        /// CTUSER.
        /// </summary>
        public const string CTUSER = "CTUSER";

        /// <summary>
        /// CTPID.
        /// </summary>
        public const string CTPID = "CTPID";

        /// <summary>
        /// CTUPMJ.
        /// </summary>
        public const string CTUPMJ = "CTUPMJ";

        /// <summary>
        /// CTJOBN.
        /// </summary>
        public const string CTJOBN = "CTJOBN";

        /// <summary>
        /// CTTDAY.
        /// </summary>
        public const string CTTDAY = "CTTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49004";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTMCU", "CTMCU", JdeDataType.String, 24, true, true),
        new JdeField("CTMOT", "CTMOT", JdeDataType.String, 6, true, true),
        new JdeField("CTJBCD", "CTJBCD", JdeDataType.String, 12),
        new JdeField("CTRLTR", "CTRLTR", JdeDataType.String, 4),
        new JdeField("CTRLTV", "CTRLTV", JdeDataType.String, 4),
        new JdeField("CTCMNF", "CTCMNF", JdeDataType.String, 2),
        new JdeField("CTLRFG", "CTLRFG", JdeDataType.String, 2),
        new JdeField("CTBNFG", "CTBNFG", JdeDataType.String, 2),
        new JdeField("CTPCSD", "CTPCSD", JdeDataType.String, 20),
        new JdeField("CTGLC", "CTGLC", JdeDataType.String, 8),
        new JdeField("CTVTYP", "CTVTYP", JdeDataType.String, 24),
        new JdeField("CTLDTY", "CTLDTY", JdeDataType.String, 4),
        new JdeField("CTLTDL", "CTLTDL", JdeDataType.Numeric),
        new JdeField("CTURCD", "CTURCD", JdeDataType.String, 4),
        new JdeField("CTURDT", "CTURDT", JdeDataType.Numeric),
        new JdeField("CTURAT", "CTURAT", JdeDataType.Numeric),
        new JdeField("CTURAB", "CTURAB", JdeDataType.Numeric),
        new JdeField("CTURRF", "CTURRF", JdeDataType.String, 30),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20),
        new JdeField("CTUPMJ", "CTUPMJ", JdeDataType.Numeric),
        new JdeField("CTJOBN", "CTJOBN", JdeDataType.String, 20),
        new JdeField("CTTDAY", "CTTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49004_0", "Primary Key on CTMCU, CTMOT", new[] { "CTMCU", "CTMOT" }, isUnique: true, isPrimaryKey: true)
    };
}
