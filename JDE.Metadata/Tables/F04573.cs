using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F04573 - .
/// </summary>
public class F04573 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KIHDC.
        /// </summary>
        public const string KIHDC = "KIHDC";

        /// <summary>
        /// KICKC.
        /// </summary>
        public const string KICKC = "KICKC";

        /// <summary>
        /// KIRC.
        /// </summary>
        public const string KIRC = "KIRC";

        /// <summary>
        /// KIKCO.
        /// </summary>
        public const string KIKCO = "KIKCO";

        /// <summary>
        /// KIDOC.
        /// </summary>
        public const string KIDOC = "KIDOC";

        /// <summary>
        /// KIDCT.
        /// </summary>
        public const string KIDCT = "KIDCT";

        /// <summary>
        /// KISFX.
        /// </summary>
        public const string KISFX = "KISFX";

        /// <summary>
        /// KIDDJ.
        /// </summary>
        public const string KIDDJ = "KIDDJ";

        /// <summary>
        /// KIAN8.
        /// </summary>
        public const string KIAN8 = "KIAN8";

        /// <summary>
        /// KICO.
        /// </summary>
        public const string KICO = "KICO";

        /// <summary>
        /// KIADSA.
        /// </summary>
        public const string KIADSA = "KIADSA";

        /// <summary>
        /// KIPAAP.
        /// </summary>
        public const string KIPAAP = "KIPAAP";

        /// <summary>
        /// KICRCD.
        /// </summary>
        public const string KICRCD = "KICRCD";

        /// <summary>
        /// KICRR.
        /// </summary>
        public const string KICRR = "KICRR";

        /// <summary>
        /// KICRRM.
        /// </summary>
        public const string KICRRM = "KICRRM";

        /// <summary>
        /// KIACR.
        /// </summary>
        public const string KIACR = "KIACR";

        /// <summary>
        /// KICDSA.
        /// </summary>
        public const string KICDSA = "KICDSA";

        /// <summary>
        /// KIEFTJ.
        /// </summary>
        public const string KIEFTJ = "KIEFTJ";

        /// <summary>
        /// KIDIVJ.
        /// </summary>
        public const string KIDIVJ = "KIDIVJ";

        /// <summary>
        /// KIVINV.
        /// </summary>
        public const string KIVINV = "KIVINV";

        /// <summary>
        /// KIRMK.
        /// </summary>
        public const string KIRMK = "KIRMK";

        /// <summary>
        /// KIPID.
        /// </summary>
        public const string KIPID = "KIPID";

        /// <summary>
        /// KIUSER.
        /// </summary>
        public const string KIUSER = "KIUSER";

        /// <summary>
        /// KIUPMJ.
        /// </summary>
        public const string KIUPMJ = "KIUPMJ";

        /// <summary>
        /// KIUPMT.
        /// </summary>
        public const string KIUPMT = "KIUPMT";

        /// <summary>
        /// KISFXE.
        /// </summary>
        public const string KISFXE = "KISFXE";

        /// <summary>
        /// KIJOBN.
        /// </summary>
        public const string KIJOBN = "KIJOBN";

        /// <summary>
        /// KIPKCO.
        /// </summary>
        public const string KIPKCO = "KIPKCO";

        /// <summary>
        /// KIPDCT.
        /// </summary>
        public const string KIPDCT = "KIPDCT";

        /// <summary>
        /// KIPO.
        /// </summary>
        public const string KIPO = "KIPO";

        /// <summary>
        /// KIRC7.
        /// </summary>
        public const string KIRC7 = "KIRC7";

        /// <summary>
        /// KIPSTO.
        /// </summary>
        public const string KIPSTO = "KIPSTO";

        /// <summary>
        /// KIGFL3.
        /// </summary>
        public const string KIGFL3 = "KIGFL3";

        /// <summary>
        /// KIGFL4.
        /// </summary>
        public const string KIGFL4 = "KIGFL4";

        /// <summary>
        /// KIDRCO.
        /// </summary>
        public const string KIDRCO = "KIDRCO";

        /// <summary>
        /// KIGRPID.
        /// </summary>
        public const string KIGRPID = "KIGRPID";

        /// <summary>
        /// KIAG.
        /// </summary>
        public const string KIAG = "KIAG";

        /// <summary>
        /// KIAAP.
        /// </summary>
        public const string KIAAP = "KIAAP";

        /// <summary>
        /// KIADSC.
        /// </summary>
        public const string KIADSC = "KIADSC";

        /// <summary>
        /// KIACR3.
        /// </summary>
        public const string KIACR3 = "KIACR3";

        /// <summary>
        /// KIFAP.
        /// </summary>
        public const string KIFAP = "KIFAP";

        /// <summary>
        /// KICDS.
        /// </summary>
        public const string KICDS = "KICDS";

        /// <summary>
        /// KIGLC.
        /// </summary>
        public const string KIGLC = "KIGLC";

        /// <summary>
        /// KIDGJ.
        /// </summary>
        public const string KIDGJ = "KIDGJ";

        /// <summary>
        /// KIMCU.
        /// </summary>
        public const string KIMCU = "KIMCU";

        /// <summary>
        /// KIBCRC.
        /// </summary>
        public const string KIBCRC = "KIBCRC";

        /// <summary>
        /// KIVCHFLG.
        /// </summary>
        public const string KIVCHFLG = "KIVCHFLG";

        /// <summary>
        /// KINETTCID.
        /// </summary>
        public const string KINETTCID = "KINETTCID";

        /// <summary>
        /// KICNTRTCD.
        /// </summary>
        public const string KICNTRTCD = "KICNTRTCD";

        /// <summary>
        /// KIBLSCD2.
        /// </summary>
        public const string KIBLSCD2 = "KIBLSCD2";

        /// <summary>
        /// KIHARPER.
        /// </summary>
        public const string KIHARPER = "KIHARPER";

        /// <summary>
        /// KIHARSFX.
        /// </summary>
        public const string KIHARSFX = "KIHARSFX";

        /// <summary>
        /// KICNTRTID.
        /// </summary>
        public const string KICNTRTID = "KICNTRTID";

        /// <summary>
        /// KIWVID.
        /// </summary>
        public const string KIWVID = "KIWVID";
    }

    /// <inheritdoc />
    public override string TableName => "F04573";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KIHDC", "KIHDC", JdeDataType.Numeric, null, true, true),
        new JdeField("KICKC", "KICKC", JdeDataType.Numeric, null, true, true),
        new JdeField("KIRC", "KIRC", JdeDataType.String, 2, true, true),
        new JdeField("KIKCO", "KIKCO", JdeDataType.String, 10, true, true),
        new JdeField("KIDOC", "KIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("KIDCT", "KIDCT", JdeDataType.String, 4, true, true),
        new JdeField("KISFX", "KISFX", JdeDataType.String, 6, true, true),
        new JdeField("KIDDJ", "KIDDJ", JdeDataType.Numeric),
        new JdeField("KIAN8", "KIAN8", JdeDataType.Numeric),
        new JdeField("KICO", "KICO", JdeDataType.String, 10),
        new JdeField("KIADSA", "KIADSA", JdeDataType.Numeric),
        new JdeField("KIPAAP", "KIPAAP", JdeDataType.Numeric),
        new JdeField("KICRCD", "KICRCD", JdeDataType.String, 6),
        new JdeField("KICRR", "KICRR", JdeDataType.Numeric),
        new JdeField("KICRRM", "KICRRM", JdeDataType.String, 2),
        new JdeField("KIACR", "KIACR", JdeDataType.Numeric),
        new JdeField("KICDSA", "KICDSA", JdeDataType.Numeric),
        new JdeField("KIEFTJ", "KIEFTJ", JdeDataType.Numeric),
        new JdeField("KIDIVJ", "KIDIVJ", JdeDataType.Numeric),
        new JdeField("KIVINV", "KIVINV", JdeDataType.String, 50),
        new JdeField("KIRMK", "KIRMK", JdeDataType.String, 60),
        new JdeField("KIPID", "KIPID", JdeDataType.String, 20),
        new JdeField("KIUSER", "KIUSER", JdeDataType.String, 20),
        new JdeField("KIUPMJ", "KIUPMJ", JdeDataType.Numeric),
        new JdeField("KIUPMT", "KIUPMT", JdeDataType.Numeric),
        new JdeField("KISFXE", "KISFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("KIJOBN", "KIJOBN", JdeDataType.String, 20),
        new JdeField("KIPKCO", "KIPKCO", JdeDataType.String, 10),
        new JdeField("KIPDCT", "KIPDCT", JdeDataType.String, 4),
        new JdeField("KIPO", "KIPO", JdeDataType.String, 16),
        new JdeField("KIRC7", "KIRC7", JdeDataType.Numeric),
        new JdeField("KIPSTO", "KIPSTO", JdeDataType.String, 2),
        new JdeField("KIGFL3", "KIGFL3", JdeDataType.String, 2),
        new JdeField("KIGFL4", "KIGFL4", JdeDataType.String, 2),
        new JdeField("KIDRCO", "KIDRCO", JdeDataType.String, 6),
        new JdeField("KIGRPID", "KIGRPID", JdeDataType.Numeric),
        new JdeField("KIAG", "KIAG", JdeDataType.Numeric),
        new JdeField("KIAAP", "KIAAP", JdeDataType.Numeric),
        new JdeField("KIADSC", "KIADSC", JdeDataType.Numeric),
        new JdeField("KIACR3", "KIACR3", JdeDataType.Numeric),
        new JdeField("KIFAP", "KIFAP", JdeDataType.Numeric),
        new JdeField("KICDS", "KICDS", JdeDataType.Numeric),
        new JdeField("KIGLC", "KIGLC", JdeDataType.String, 8),
        new JdeField("KIDGJ", "KIDGJ", JdeDataType.Numeric),
        new JdeField("KIMCU", "KIMCU", JdeDataType.String, 24),
        new JdeField("KIBCRC", "KIBCRC", JdeDataType.String, 6),
        new JdeField("KIVCHFLG", "KIVCHFLG", JdeDataType.String, 2),
        new JdeField("KINETTCID", "KINETTCID", JdeDataType.Numeric),
        new JdeField("KICNTRTCD", "KICNTRTCD", JdeDataType.String, 24),
        new JdeField("KIBLSCD2", "KIBLSCD2", JdeDataType.String, 20),
        new JdeField("KIHARPER", "KIHARPER", JdeDataType.String, 12),
        new JdeField("KIHARSFX", "KIHARSFX", JdeDataType.String, 20),
        new JdeField("KICNTRTID", "KICNTRTID", JdeDataType.Numeric),
        new JdeField("KIWVID", "KIWVID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F04573_0", "Primary Key on KIHDC, KICKC, KIRC, KIDOC, KIDCT, KIKCO, KISFX, KISFXE", new[] { "KIHDC", "KICKC", "KIRC", "KIDOC", "KIDCT", "KIKCO", "KISFX", "KISFXE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F04573_2", "Index on KIHDC, KICKC, KIRC, KIDOC, KIDCT, KIKCO, KIGRPID", new[] { "KIHDC", "KICKC", "KIRC", "KIDOC", "KIDCT", "KIKCO", "KIGRPID" }),
        new JdeIndex("F04573_3", "Index on KIHDC, KICKC", new[] { "KIHDC", "KICKC" })
    };
}
