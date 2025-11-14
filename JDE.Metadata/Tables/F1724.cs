using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1724 - .
/// </summary>
public class F1724 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTCOVT.
        /// </summary>
        public const string CTCOVT = "CTCOVT";

        /// <summary>
        /// CTDL01.
        /// </summary>
        public const string CTDL01 = "CTDL01";

        /// <summary>
        /// CTTIMEZONES.
        /// </summary>
        public const string CTTIMEZONES = "CTTIMEZONES";

        /// <summary>
        /// CTDSAVNAME.
        /// </summary>
        public const string CTDSAVNAME = "CTDSAVNAME";

        /// <summary>
        /// CTBEG1.
        /// </summary>
        public const string CTBEG1 = "CTBEG1";

        /// <summary>
        /// CTBEG2.
        /// </summary>
        public const string CTBEG2 = "CTBEG2";

        /// <summary>
        /// CTBEG3.
        /// </summary>
        public const string CTBEG3 = "CTBEG3";

        /// <summary>
        /// CTBEG4.
        /// </summary>
        public const string CTBEG4 = "CTBEG4";

        /// <summary>
        /// CTBEG5.
        /// </summary>
        public const string CTBEG5 = "CTBEG5";

        /// <summary>
        /// CTBEG6.
        /// </summary>
        public const string CTBEG6 = "CTBEG6";

        /// <summary>
        /// CTBEG7.
        /// </summary>
        public const string CTBEG7 = "CTBEG7";

        /// <summary>
        /// CTBEG8.
        /// </summary>
        public const string CTBEG8 = "CTBEG8";

        /// <summary>
        /// CTECV1.
        /// </summary>
        public const string CTECV1 = "CTECV1";

        /// <summary>
        /// CTECV2.
        /// </summary>
        public const string CTECV2 = "CTECV2";

        /// <summary>
        /// CTECV3.
        /// </summary>
        public const string CTECV3 = "CTECV3";

        /// <summary>
        /// CTECV4.
        /// </summary>
        public const string CTECV4 = "CTECV4";

        /// <summary>
        /// CTECV5.
        /// </summary>
        public const string CTECV5 = "CTECV5";

        /// <summary>
        /// CTECV6.
        /// </summary>
        public const string CTECV6 = "CTECV6";

        /// <summary>
        /// CTECV7.
        /// </summary>
        public const string CTECV7 = "CTECV7";

        /// <summary>
        /// CTECV8.
        /// </summary>
        public const string CTECV8 = "CTECV8";

        /// <summary>
        /// CTKT01.
        /// </summary>
        public const string CTKT01 = "CTKT01";

        /// <summary>
        /// CTKT02.
        /// </summary>
        public const string CTKT02 = "CTKT02";

        /// <summary>
        /// CTKT03.
        /// </summary>
        public const string CTKT03 = "CTKT03";

        /// <summary>
        /// CTKT04.
        /// </summary>
        public const string CTKT04 = "CTKT04";

        /// <summary>
        /// CTKT05.
        /// </summary>
        public const string CTKT05 = "CTKT05";

        /// <summary>
        /// CTCRTU.
        /// </summary>
        public const string CTCRTU = "CTCRTU";

        /// <summary>
        /// CTPID.
        /// </summary>
        public const string CTPID = "CTPID";

        /// <summary>
        /// CTJOBN.
        /// </summary>
        public const string CTJOBN = "CTJOBN";

        /// <summary>
        /// CTUSER.
        /// </summary>
        public const string CTUSER = "CTUSER";

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
    public override string TableName => "F1724";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTCOVT", "CTCOVT", JdeDataType.String, 20, true, true),
        new JdeField("CTDL01", "CTDL01", JdeDataType.String, 60),
        new JdeField("CTTIMEZONES", "CTTIMEZONES", JdeDataType.String, 4),
        new JdeField("CTDSAVNAME", "CTDSAVNAME", JdeDataType.String, 20),
        new JdeField("CTBEG1", "CTBEG1", JdeDataType.Numeric),
        new JdeField("CTBEG2", "CTBEG2", JdeDataType.Numeric),
        new JdeField("CTBEG3", "CTBEG3", JdeDataType.Numeric),
        new JdeField("CTBEG4", "CTBEG4", JdeDataType.Numeric),
        new JdeField("CTBEG5", "CTBEG5", JdeDataType.Numeric),
        new JdeField("CTBEG6", "CTBEG6", JdeDataType.Numeric),
        new JdeField("CTBEG7", "CTBEG7", JdeDataType.Numeric),
        new JdeField("CTBEG8", "CTBEG8", JdeDataType.Numeric),
        new JdeField("CTECV1", "CTECV1", JdeDataType.Numeric),
        new JdeField("CTECV2", "CTECV2", JdeDataType.Numeric),
        new JdeField("CTECV3", "CTECV3", JdeDataType.Numeric),
        new JdeField("CTECV4", "CTECV4", JdeDataType.Numeric),
        new JdeField("CTECV5", "CTECV5", JdeDataType.Numeric),
        new JdeField("CTECV6", "CTECV6", JdeDataType.Numeric),
        new JdeField("CTECV7", "CTECV7", JdeDataType.Numeric),
        new JdeField("CTECV8", "CTECV8", JdeDataType.Numeric),
        new JdeField("CTKT01", "CTKT01", JdeDataType.String, 20),
        new JdeField("CTKT02", "CTKT02", JdeDataType.String, 20),
        new JdeField("CTKT03", "CTKT03", JdeDataType.String, 20),
        new JdeField("CTKT04", "CTKT04", JdeDataType.String, 20),
        new JdeField("CTKT05", "CTKT05", JdeDataType.String, 20),
        new JdeField("CTCRTU", "CTCRTU", JdeDataType.String, 20),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20),
        new JdeField("CTJOBN", "CTJOBN", JdeDataType.String, 20),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTUPMJ", "CTUPMJ", JdeDataType.Numeric),
        new JdeField("CTUPMT", "CTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1724_0", "Primary Key on CTCOVT", new[] { "CTCOVT" }, isUnique: true, isPrimaryKey: true)
    };
}
