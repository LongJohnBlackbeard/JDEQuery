using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3400 - .
/// </summary>
public class F3400 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SGKVER.
        /// </summary>
        public const string SGKVER = "SGKVER";

        /// <summary>
        /// SGTYPF.
        /// </summary>
        public const string SGTYPF = "SGTYPF";

        /// <summary>
        /// SGKV01.
        /// </summary>
        public const string SGKV01 = "SGKV01";

        /// <summary>
        /// SGKV02.
        /// </summary>
        public const string SGKV02 = "SGKV02";

        /// <summary>
        /// SGKV03.
        /// </summary>
        public const string SGKV03 = "SGKV03";

        /// <summary>
        /// SGKV04.
        /// </summary>
        public const string SGKV04 = "SGKV04";

        /// <summary>
        /// SGKV05.
        /// </summary>
        public const string SGKV05 = "SGKV05";

        /// <summary>
        /// SGKV06.
        /// </summary>
        public const string SGKV06 = "SGKV06";

        /// <summary>
        /// SGKV07.
        /// </summary>
        public const string SGKV07 = "SGKV07";

        /// <summary>
        /// SGKV08.
        /// </summary>
        public const string SGKV08 = "SGKV08";

        /// <summary>
        /// SGKV09.
        /// </summary>
        public const string SGKV09 = "SGKV09";

        /// <summary>
        /// SGKV10.
        /// </summary>
        public const string SGKV10 = "SGKV10";

        /// <summary>
        /// SGCO.
        /// </summary>
        public const string SGCO = "SGCO";

        /// <summary>
        /// SGITM.
        /// </summary>
        public const string SGITM = "SGITM";

        /// <summary>
        /// SGAN8.
        /// </summary>
        public const string SGAN8 = "SGAN8";

        /// <summary>
        /// SGDRQJ.
        /// </summary>
        public const string SGDRQJ = "SGDRQJ";

        /// <summary>
        /// SGUORG.
        /// </summary>
        public const string SGUORG = "SGUORG";

        /// <summary>
        /// SGAEXP.
        /// </summary>
        public const string SGAEXP = "SGAEXP";

        /// <summary>
        /// SGFAM.
        /// </summary>
        public const string SGFAM = "SGFAM";

        /// <summary>
        /// SGFQT.
        /// </summary>
        public const string SGFQT = "SGFQT";

        /// <summary>
        /// SGSFKY.
        /// </summary>
        public const string SGSFKY = "SGSFKY";

        /// <summary>
        /// SGSFKE.
        /// </summary>
        public const string SGSFKE = "SGSFKE";

        /// <summary>
        /// SGBPFC.
        /// </summary>
        public const string SGBPFC = "SGBPFC";

        /// <summary>
        /// SGRVIS.
        /// </summary>
        public const string SGRVIS = "SGRVIS";

        /// <summary>
        /// SGUPMJ.
        /// </summary>
        public const string SGUPMJ = "SGUPMJ";

        /// <summary>
        /// SGUSER.
        /// </summary>
        public const string SGUSER = "SGUSER";

        /// <summary>
        /// SGJOBN.
        /// </summary>
        public const string SGJOBN = "SGJOBN";

        /// <summary>
        /// SGPID.
        /// </summary>
        public const string SGPID = "SGPID";

        /// <summary>
        /// SGTDAY.
        /// </summary>
        public const string SGTDAY = "SGTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F3400";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SGKVER", "SGKVER", JdeDataType.String, 6, true, true),
        new JdeField("SGTYPF", "SGTYPF", JdeDataType.String, 4, true, true),
        new JdeField("SGKV01", "SGKV01", JdeDataType.String, 12, true, true),
        new JdeField("SGKV02", "SGKV02", JdeDataType.String, 12, true, true),
        new JdeField("SGKV03", "SGKV03", JdeDataType.String, 12, true, true),
        new JdeField("SGKV04", "SGKV04", JdeDataType.String, 12, true, true),
        new JdeField("SGKV05", "SGKV05", JdeDataType.String, 12, true, true),
        new JdeField("SGKV06", "SGKV06", JdeDataType.String, 12, true, true),
        new JdeField("SGKV07", "SGKV07", JdeDataType.String, 12, true, true),
        new JdeField("SGKV08", "SGKV08", JdeDataType.String, 12, true, true),
        new JdeField("SGKV09", "SGKV09", JdeDataType.String, 12, true, true),
        new JdeField("SGKV10", "SGKV10", JdeDataType.String, 12, true, true),
        new JdeField("SGCO", "SGCO", JdeDataType.String, 10, true, true),
        new JdeField("SGITM", "SGITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SGAN8", "SGAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SGDRQJ", "SGDRQJ", JdeDataType.Numeric, null, true, true),
        new JdeField("SGUORG", "SGUORG", JdeDataType.Numeric),
        new JdeField("SGAEXP", "SGAEXP", JdeDataType.Numeric),
        new JdeField("SGFAM", "SGFAM", JdeDataType.Numeric),
        new JdeField("SGFQT", "SGFQT", JdeDataType.Numeric),
        new JdeField("SGSFKY", "SGSFKY", JdeDataType.Numeric),
        new JdeField("SGSFKE", "SGSFKE", JdeDataType.Numeric),
        new JdeField("SGBPFC", "SGBPFC", JdeDataType.String, 2),
        new JdeField("SGRVIS", "SGRVIS", JdeDataType.String, 2),
        new JdeField("SGUPMJ", "SGUPMJ", JdeDataType.Numeric),
        new JdeField("SGUSER", "SGUSER", JdeDataType.String, 20),
        new JdeField("SGJOBN", "SGJOBN", JdeDataType.String, 20),
        new JdeField("SGPID", "SGPID", JdeDataType.String, 20),
        new JdeField("SGTDAY", "SGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3400_0", "Primary Key on SGKVER, SGTYPF, SGCO, SGKV01, SGKV02, SGKV03, SGKV04, SGKV05, SGKV06, SGKV07, SGKV08, SGKV09, SGKV10, SGAN8, SGITM, SGDRQJ", new[] { "SGKVER", "SGTYPF", "SGCO", "SGKV01", "SGKV02", "SGKV03", "SGKV04", "SGKV05", "SGKV06", "SGKV07", "SGKV08", "SGKV09", "SGKV10", "SGAN8", "SGITM", "SGDRQJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3400_2", "Index on SGSFKY, SGBPFC", new[] { "SGSFKY", "SGBPFC" }),
        new JdeIndex("F3400_3", "Index on SGSFKE", new[] { "SGSFKE" }),
        new JdeIndex("F3400_4", "Index on SGKVER, SGTYPF, SGDRQJ", new[] { "SGKVER", "SGTYPF", "SGDRQJ" })
    };
}
