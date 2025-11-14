using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09370W - .
/// </summary>
public class F09370W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BWRUNID.
        /// </summary>
        public const string BWRUNID = "BWRUNID";

        /// <summary>
        /// BWLINN.
        /// </summary>
        public const string BWLINN = "BWLINN";

        /// <summary>
        /// BWCSTN.
        /// </summary>
        public const string BWCSTN = "BWCSTN";

        /// <summary>
        /// BWFY.
        /// </summary>
        public const string BWFY = "BWFY";

        /// <summary>
        /// BWLT.
        /// </summary>
        public const string BWLT = "BWLT";

        /// <summary>
        /// BWGRPV1.
        /// </summary>
        public const string BWGRPV1 = "BWGRPV1";

        /// <summary>
        /// BWGRPV2.
        /// </summary>
        public const string BWGRPV2 = "BWGRPV2";

        /// <summary>
        /// BWGRPV3.
        /// </summary>
        public const string BWGRPV3 = "BWGRPV3";

        /// <summary>
        /// BWGRPV4.
        /// </summary>
        public const string BWGRPV4 = "BWGRPV4";

        /// <summary>
        /// BWGRPV5.
        /// </summary>
        public const string BWGRPV5 = "BWGRPV5";

        /// <summary>
        /// BWGRPV6.
        /// </summary>
        public const string BWGRPV6 = "BWGRPV6";

        /// <summary>
        /// BWGRPV7.
        /// </summary>
        public const string BWGRPV7 = "BWGRPV7";

        /// <summary>
        /// BWGRPV8.
        /// </summary>
        public const string BWGRPV8 = "BWGRPV8";

        /// <summary>
        /// BWGRPV9.
        /// </summary>
        public const string BWGRPV9 = "BWGRPV9";

        /// <summary>
        /// BWGRPV10.
        /// </summary>
        public const string BWGRPV10 = "BWGRPV10";

        /// <summary>
        /// BWAPYC.
        /// </summary>
        public const string BWAPYC = "BWAPYC";

        /// <summary>
        /// BWAN01.
        /// </summary>
        public const string BWAN01 = "BWAN01";

        /// <summary>
        /// BWAN02.
        /// </summary>
        public const string BWAN02 = "BWAN02";

        /// <summary>
        /// BWAN03.
        /// </summary>
        public const string BWAN03 = "BWAN03";

        /// <summary>
        /// BWAN04.
        /// </summary>
        public const string BWAN04 = "BWAN04";

        /// <summary>
        /// BWAN05.
        /// </summary>
        public const string BWAN05 = "BWAN05";

        /// <summary>
        /// BWAN06.
        /// </summary>
        public const string BWAN06 = "BWAN06";

        /// <summary>
        /// BWAN07.
        /// </summary>
        public const string BWAN07 = "BWAN07";

        /// <summary>
        /// BWAN08.
        /// </summary>
        public const string BWAN08 = "BWAN08";

        /// <summary>
        /// BWAN09.
        /// </summary>
        public const string BWAN09 = "BWAN09";

        /// <summary>
        /// BWAN10.
        /// </summary>
        public const string BWAN10 = "BWAN10";

        /// <summary>
        /// BWAN11.
        /// </summary>
        public const string BWAN11 = "BWAN11";

        /// <summary>
        /// BWAN12.
        /// </summary>
        public const string BWAN12 = "BWAN12";

        /// <summary>
        /// BWAN13.
        /// </summary>
        public const string BWAN13 = "BWAN13";

        /// <summary>
        /// BWAN14.
        /// </summary>
        public const string BWAN14 = "BWAN14";

        /// <summary>
        /// BWAND01.
        /// </summary>
        public const string BWAND01 = "BWAND01";

        /// <summary>
        /// BWAND02.
        /// </summary>
        public const string BWAND02 = "BWAND02";

        /// <summary>
        /// BWAND03.
        /// </summary>
        public const string BWAND03 = "BWAND03";

        /// <summary>
        /// BWAND04.
        /// </summary>
        public const string BWAND04 = "BWAND04";

        /// <summary>
        /// BWAND05.
        /// </summary>
        public const string BWAND05 = "BWAND05";

        /// <summary>
        /// BWAND06.
        /// </summary>
        public const string BWAND06 = "BWAND06";

        /// <summary>
        /// BWAND07.
        /// </summary>
        public const string BWAND07 = "BWAND07";

        /// <summary>
        /// BWAND08.
        /// </summary>
        public const string BWAND08 = "BWAND08";

        /// <summary>
        /// BWAND09.
        /// </summary>
        public const string BWAND09 = "BWAND09";

        /// <summary>
        /// BWAND10.
        /// </summary>
        public const string BWAND10 = "BWAND10";

        /// <summary>
        /// BWAND11.
        /// </summary>
        public const string BWAND11 = "BWAND11";

        /// <summary>
        /// BWAND12.
        /// </summary>
        public const string BWAND12 = "BWAND12";

        /// <summary>
        /// BWAND13.
        /// </summary>
        public const string BWAND13 = "BWAND13";

        /// <summary>
        /// BWAND14.
        /// </summary>
        public const string BWAND14 = "BWAND14";

        /// <summary>
        /// BWCRCX.
        /// </summary>
        public const string BWCRCX = "BWCRCX";

        /// <summary>
        /// BWUSER.
        /// </summary>
        public const string BWUSER = "BWUSER";

        /// <summary>
        /// BWRPSTN.
        /// </summary>
        public const string BWRPSTN = "BWRPSTN";

        /// <summary>
        /// BWVERN.
        /// </summary>
        public const string BWVERN = "BWVERN";
    }

    /// <inheritdoc />
    public override string TableName => "F09370W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BWRUNID", "BWRUNID", JdeDataType.Numeric, null, true, true),
        new JdeField("BWLINN", "BWLINN", JdeDataType.Numeric, null, true, true),
        new JdeField("BWCSTN", "BWCSTN", JdeDataType.String, 40, true, true),
        new JdeField("BWFY", "BWFY", JdeDataType.Numeric, null, true, true),
        new JdeField("BWLT", "BWLT", JdeDataType.String, 4, true, true),
        new JdeField("BWGRPV1", "BWGRPV1", JdeDataType.String, 60, true, true),
        new JdeField("BWGRPV2", "BWGRPV2", JdeDataType.String, 60, true, true),
        new JdeField("BWGRPV3", "BWGRPV3", JdeDataType.String, 60, true, true),
        new JdeField("BWGRPV4", "BWGRPV4", JdeDataType.String, 60, true, true),
        new JdeField("BWGRPV5", "BWGRPV5", JdeDataType.String, 60, true, true),
        new JdeField("BWGRPV6", "BWGRPV6", JdeDataType.String, 60, true, true),
        new JdeField("BWGRPV7", "BWGRPV7", JdeDataType.String, 60, true, true),
        new JdeField("BWGRPV8", "BWGRPV8", JdeDataType.String, 60, true, true),
        new JdeField("BWGRPV9", "BWGRPV9", JdeDataType.String, 60, true, true),
        new JdeField("BWGRPV10", "BWGRPV10", JdeDataType.String, 60, true, true),
        new JdeField("BWAPYC", "BWAPYC", JdeDataType.Numeric),
        new JdeField("BWAN01", "BWAN01", JdeDataType.Numeric),
        new JdeField("BWAN02", "BWAN02", JdeDataType.Numeric),
        new JdeField("BWAN03", "BWAN03", JdeDataType.Numeric),
        new JdeField("BWAN04", "BWAN04", JdeDataType.Numeric),
        new JdeField("BWAN05", "BWAN05", JdeDataType.Numeric),
        new JdeField("BWAN06", "BWAN06", JdeDataType.Numeric),
        new JdeField("BWAN07", "BWAN07", JdeDataType.Numeric),
        new JdeField("BWAN08", "BWAN08", JdeDataType.Numeric),
        new JdeField("BWAN09", "BWAN09", JdeDataType.Numeric),
        new JdeField("BWAN10", "BWAN10", JdeDataType.Numeric),
        new JdeField("BWAN11", "BWAN11", JdeDataType.Numeric),
        new JdeField("BWAN12", "BWAN12", JdeDataType.Numeric),
        new JdeField("BWAN13", "BWAN13", JdeDataType.Numeric),
        new JdeField("BWAN14", "BWAN14", JdeDataType.Numeric),
        new JdeField("BWAND01", "BWAND01", JdeDataType.Numeric),
        new JdeField("BWAND02", "BWAND02", JdeDataType.Numeric),
        new JdeField("BWAND03", "BWAND03", JdeDataType.Numeric),
        new JdeField("BWAND04", "BWAND04", JdeDataType.Numeric),
        new JdeField("BWAND05", "BWAND05", JdeDataType.Numeric),
        new JdeField("BWAND06", "BWAND06", JdeDataType.Numeric),
        new JdeField("BWAND07", "BWAND07", JdeDataType.Numeric),
        new JdeField("BWAND08", "BWAND08", JdeDataType.Numeric),
        new JdeField("BWAND09", "BWAND09", JdeDataType.Numeric),
        new JdeField("BWAND10", "BWAND10", JdeDataType.Numeric),
        new JdeField("BWAND11", "BWAND11", JdeDataType.Numeric),
        new JdeField("BWAND12", "BWAND12", JdeDataType.Numeric),
        new JdeField("BWAND13", "BWAND13", JdeDataType.Numeric),
        new JdeField("BWAND14", "BWAND14", JdeDataType.Numeric),
        new JdeField("BWCRCX", "BWCRCX", JdeDataType.String, 6, true, true),
        new JdeField("BWUSER", "BWUSER", JdeDataType.String, 20),
        new JdeField("BWRPSTN", "BWRPSTN", JdeDataType.String, 40),
        new JdeField("BWVERN", "BWVERN", JdeDataType.String, 40)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09370W_0", "Primary Key on BWRUNID, BWLINN, BWCSTN, BWFY, BWLT, BWGRPV1, BWGRPV2, BWGRPV3, BWGRPV4, BWGRPV5, BWGRPV6, BWGRPV7, BWGRPV8, BWGRPV9, BWGRPV10, BWCRCX", new[] { "BWRUNID", "BWLINN", "BWCSTN", "BWFY", "BWLT", "BWGRPV1", "BWGRPV2", "BWGRPV3", "BWGRPV4", "BWGRPV5", "BWGRPV6", "BWGRPV7", "BWGRPV8", "BWGRPV9", "BWGRPV10", "BWCRCX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09370W_2", "Index on BWUSER, BWRPSTN, BWVERN", new[] { "BWUSER", "BWRPSTN", "BWVERN" }),
        new JdeIndex("F09370W_3", "Index on BWRUNID, BWLINN, BWGRPV1, BWGRPV2, BWGRPV3, BWGRPV4, BWGRPV5, BWGRPV6, BWGRPV7, BWGRPV8, BWGRPV9, BWGRPV10", new[] { "BWRUNID", "BWLINN", "BWGRPV1", "BWGRPV2", "BWGRPV3", "BWGRPV4", "BWGRPV5", "BWGRPV6", "BWGRPV7", "BWGRPV8", "BWGRPV9", "BWGRPV10" })
    };
}
