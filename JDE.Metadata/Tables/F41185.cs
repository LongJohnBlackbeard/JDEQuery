using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41185 - .
/// </summary>
public class F41185 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTITM.
        /// </summary>
        public const string CTITM = "CTITM";

        /// <summary>
        /// CTITRF.
        /// </summary>
        public const string CTITRF = "CTITRF";

        /// <summary>
        /// CTMCU.
        /// </summary>
        public const string CTMCU = "CTMCU";

        /// <summary>
        /// CTCO.
        /// </summary>
        public const string CTCO = "CTCO";

        /// <summary>
        /// CTTOQT.
        /// </summary>
        public const string CTTOQT = "CTTOQT";

        /// <summary>
        /// CTODQT.
        /// </summary>
        public const string CTODQT = "CTODQT";

        /// <summary>
        /// CTCDQT.
        /// </summary>
        public const string CTCDQT = "CTCDQT";

        /// <summary>
        /// CTUPMJ.
        /// </summary>
        public const string CTUPMJ = "CTUPMJ";

        /// <summary>
        /// CTUKID.
        /// </summary>
        public const string CTUKID = "CTUKID";

        /// <summary>
        /// CTURAT.
        /// </summary>
        public const string CTURAT = "CTURAT";

        /// <summary>
        /// CTURCD.
        /// </summary>
        public const string CTURCD = "CTURCD";

        /// <summary>
        /// CTURDT.
        /// </summary>
        public const string CTURDT = "CTURDT";

        /// <summary>
        /// CTURAB.
        /// </summary>
        public const string CTURAB = "CTURAB";

        /// <summary>
        /// CTCTQT.
        /// </summary>
        public const string CTCTQT = "CTCTQT";

        /// <summary>
        /// CTCTCD.
        /// </summary>
        public const string CTCTCD = "CTCTCD";

        /// <summary>
        /// CTCMDT.
        /// </summary>
        public const string CTCMDT = "CTCMDT";

        /// <summary>
        /// CTCM01.
        /// </summary>
        public const string CTCM01 = "CTCM01";

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
        /// CTTDAY.
        /// </summary>
        public const string CTTDAY = "CTTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F41185";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTITM", "CTITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CTITRF", "CTITRF", JdeDataType.Numeric),
        new JdeField("CTMCU", "CTMCU", JdeDataType.String, 24, true, true),
        new JdeField("CTCO", "CTCO", JdeDataType.String, 10, true, true),
        new JdeField("CTTOQT", "CTTOQT", JdeDataType.Numeric),
        new JdeField("CTODQT", "CTODQT", JdeDataType.Numeric),
        new JdeField("CTCDQT", "CTCDQT", JdeDataType.Numeric),
        new JdeField("CTUPMJ", "CTUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CTUKID", "CTUKID", JdeDataType.Numeric),
        new JdeField("CTURAT", "CTURAT", JdeDataType.Numeric),
        new JdeField("CTURCD", "CTURCD", JdeDataType.String, 4),
        new JdeField("CTURDT", "CTURDT", JdeDataType.Numeric),
        new JdeField("CTURAB", "CTURAB", JdeDataType.Numeric),
        new JdeField("CTCTQT", "CTCTQT", JdeDataType.Numeric),
        new JdeField("CTCTCD", "CTCTCD", JdeDataType.String, 4),
        new JdeField("CTCMDT", "CTCMDT", JdeDataType.Numeric),
        new JdeField("CTCM01", "CTCM01", JdeDataType.String, 2),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20),
        new JdeField("CTJOBN", "CTJOBN", JdeDataType.String, 20),
        new JdeField("CTTDAY", "CTTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41185_0", "Primary Key on CTITM, CTMCU, CTCO, CTUPMJ", new[] { "CTITM", "CTMCU", "CTCO", "CTUPMJ" }, isUnique: true, isPrimaryKey: true)
    };
}
