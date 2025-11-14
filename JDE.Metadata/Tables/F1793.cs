using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1793 - .
/// </summary>
public class F1793 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LFLNTY.
        /// </summary>
        public const string LFLNTY = "LFLNTY";

        /// <summary>
        /// LFYN26.
        /// </summary>
        public const string LFYN26 = "LFYN26";

        /// <summary>
        /// LFYN27.
        /// </summary>
        public const string LFYN27 = "LFYN27";

        /// <summary>
        /// LFYN28.
        /// </summary>
        public const string LFYN28 = "LFYN28";

        /// <summary>
        /// LFYN29.
        /// </summary>
        public const string LFYN29 = "LFYN29";

        /// <summary>
        /// LFYN30.
        /// </summary>
        public const string LFYN30 = "LFYN30";

        /// <summary>
        /// LFDCTO.
        /// </summary>
        public const string LFDCTO = "LFDCTO";

        /// <summary>
        /// LFCRTU.
        /// </summary>
        public const string LFCRTU = "LFCRTU";

        /// <summary>
        /// LFUSER.
        /// </summary>
        public const string LFUSER = "LFUSER";

        /// <summary>
        /// LFPID.
        /// </summary>
        public const string LFPID = "LFPID";

        /// <summary>
        /// LFJOBN.
        /// </summary>
        public const string LFJOBN = "LFJOBN";

        /// <summary>
        /// LFUPMJ.
        /// </summary>
        public const string LFUPMJ = "LFUPMJ";

        /// <summary>
        /// LFUPMT.
        /// </summary>
        public const string LFUPMT = "LFUPMT";

        /// <summary>
        /// LFMCUZ.
        /// </summary>
        public const string LFMCUZ = "LFMCUZ";

        /// <summary>
        /// LFBTF01.
        /// </summary>
        public const string LFBTF01 = "LFBTF01";

        /// <summary>
        /// LFBTF02.
        /// </summary>
        public const string LFBTF02 = "LFBTF02";

        /// <summary>
        /// LFBTF03.
        /// </summary>
        public const string LFBTF03 = "LFBTF03";

        /// <summary>
        /// LFBTF04.
        /// </summary>
        public const string LFBTF04 = "LFBTF04";

        /// <summary>
        /// LFBTF05.
        /// </summary>
        public const string LFBTF05 = "LFBTF05";

        /// <summary>
        /// LFBTF06.
        /// </summary>
        public const string LFBTF06 = "LFBTF06";

        /// <summary>
        /// LFBTF07.
        /// </summary>
        public const string LFBTF07 = "LFBTF07";

        /// <summary>
        /// LFBTF08.
        /// </summary>
        public const string LFBTF08 = "LFBTF08";

        /// <summary>
        /// LFBTF09.
        /// </summary>
        public const string LFBTF09 = "LFBTF09";

        /// <summary>
        /// LFBTF10.
        /// </summary>
        public const string LFBTF10 = "LFBTF10";

        /// <summary>
        /// LFBHV01.
        /// </summary>
        public const string LFBHV01 = "LFBHV01";

        /// <summary>
        /// LFBHV02.
        /// </summary>
        public const string LFBHV02 = "LFBHV02";

        /// <summary>
        /// LFBHV03.
        /// </summary>
        public const string LFBHV03 = "LFBHV03";

        /// <summary>
        /// LFBHV04.
        /// </summary>
        public const string LFBHV04 = "LFBHV04";

        /// <summary>
        /// LFBHV05.
        /// </summary>
        public const string LFBHV05 = "LFBHV05";

        /// <summary>
        /// LFBHV06.
        /// </summary>
        public const string LFBHV06 = "LFBHV06";

        /// <summary>
        /// LFBHV07.
        /// </summary>
        public const string LFBHV07 = "LFBHV07";

        /// <summary>
        /// LFBHV08.
        /// </summary>
        public const string LFBHV08 = "LFBHV08";

        /// <summary>
        /// LFBHV09.
        /// </summary>
        public const string LFBHV09 = "LFBHV09";

        /// <summary>
        /// LFBHV10.
        /// </summary>
        public const string LFBHV10 = "LFBHV10";

        /// <summary>
        /// LFUBHV1.
        /// </summary>
        public const string LFUBHV1 = "LFUBHV1";

        /// <summary>
        /// LFUBHV2.
        /// </summary>
        public const string LFUBHV2 = "LFUBHV2";

        /// <summary>
        /// LFUBHV3.
        /// </summary>
        public const string LFUBHV3 = "LFUBHV3";

        /// <summary>
        /// LFUBHV4.
        /// </summary>
        public const string LFUBHV4 = "LFUBHV4";

        /// <summary>
        /// LFUBHV5.
        /// </summary>
        public const string LFUBHV5 = "LFUBHV5";

        /// <summary>
        /// LFDCT.
        /// </summary>
        public const string LFDCT = "LFDCT";
    }

    /// <inheritdoc />
    public override string TableName => "F1793";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LFLNTY", "LFLNTY", JdeDataType.String, 4, true, true),
        new JdeField("LFYN26", "LFYN26", JdeDataType.String, 2),
        new JdeField("LFYN27", "LFYN27", JdeDataType.String, 2),
        new JdeField("LFYN28", "LFYN28", JdeDataType.String, 2),
        new JdeField("LFYN29", "LFYN29", JdeDataType.String, 2),
        new JdeField("LFYN30", "LFYN30", JdeDataType.String, 2),
        new JdeField("LFDCTO", "LFDCTO", JdeDataType.String, 4),
        new JdeField("LFCRTU", "LFCRTU", JdeDataType.String, 20),
        new JdeField("LFUSER", "LFUSER", JdeDataType.String, 20),
        new JdeField("LFPID", "LFPID", JdeDataType.String, 20),
        new JdeField("LFJOBN", "LFJOBN", JdeDataType.String, 20),
        new JdeField("LFUPMJ", "LFUPMJ", JdeDataType.Numeric),
        new JdeField("LFUPMT", "LFUPMT", JdeDataType.Numeric),
        new JdeField("LFMCUZ", "LFMCUZ", JdeDataType.String, 24),
        new JdeField("LFBTF01", "LFBTF01", JdeDataType.String, 2),
        new JdeField("LFBTF02", "LFBTF02", JdeDataType.String, 2),
        new JdeField("LFBTF03", "LFBTF03", JdeDataType.String, 2),
        new JdeField("LFBTF04", "LFBTF04", JdeDataType.String, 2),
        new JdeField("LFBTF05", "LFBTF05", JdeDataType.String, 2),
        new JdeField("LFBTF06", "LFBTF06", JdeDataType.String, 2),
        new JdeField("LFBTF07", "LFBTF07", JdeDataType.String, 2),
        new JdeField("LFBTF08", "LFBTF08", JdeDataType.String, 2),
        new JdeField("LFBTF09", "LFBTF09", JdeDataType.String, 2),
        new JdeField("LFBTF10", "LFBTF10", JdeDataType.String, 2),
        new JdeField("LFBHV01", "LFBHV01", JdeDataType.String, 2),
        new JdeField("LFBHV02", "LFBHV02", JdeDataType.String, 2),
        new JdeField("LFBHV03", "LFBHV03", JdeDataType.String, 2),
        new JdeField("LFBHV04", "LFBHV04", JdeDataType.String, 2),
        new JdeField("LFBHV05", "LFBHV05", JdeDataType.String, 2),
        new JdeField("LFBHV06", "LFBHV06", JdeDataType.String, 2),
        new JdeField("LFBHV07", "LFBHV07", JdeDataType.String, 2),
        new JdeField("LFBHV08", "LFBHV08", JdeDataType.String, 2),
        new JdeField("LFBHV09", "LFBHV09", JdeDataType.String, 2),
        new JdeField("LFBHV10", "LFBHV10", JdeDataType.String, 2),
        new JdeField("LFUBHV1", "LFUBHV1", JdeDataType.String, 16),
        new JdeField("LFUBHV2", "LFUBHV2", JdeDataType.String, 16),
        new JdeField("LFUBHV3", "LFUBHV3", JdeDataType.String, 16),
        new JdeField("LFUBHV4", "LFUBHV4", JdeDataType.String, 16),
        new JdeField("LFUBHV5", "LFUBHV5", JdeDataType.String, 16),
        new JdeField("LFDCT", "LFDCT", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1793_0", "Primary Key on LFLNTY", new[] { "LFLNTY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1793_2", "Index on LFYN26", new[] { "LFYN26" })
    };
}
