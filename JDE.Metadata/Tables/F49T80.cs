using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49T80 - .
/// </summary>
public class F49T80 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCAN8.
        /// </summary>
        public const string LCAN8 = "LCAN8";

        /// <summary>
        /// LCAT1.
        /// </summary>
        public const string LCAT1 = "LCAT1";

        /// <summary>
        /// LCOTLOCROL.
        /// </summary>
        public const string LCOTLOCROL = "LCOTLOCROL";

        /// <summary>
        /// LCALPH.
        /// </summary>
        public const string LCALPH = "LCALPH";

        /// <summary>
        /// LCPA8.
        /// </summary>
        public const string LCPA8 = "LCPA8";

        /// <summary>
        /// LCALPH2.
        /// </summary>
        public const string LCALPH2 = "LCALPH2";

        /// <summary>
        /// LCCO.
        /// </summary>
        public const string LCCO = "LCCO";

        /// <summary>
        /// LCCRCD.
        /// </summary>
        public const string LCCRCD = "LCCRCD";

        /// <summary>
        /// LCADD1.
        /// </summary>
        public const string LCADD1 = "LCADD1";

        /// <summary>
        /// LCADD2.
        /// </summary>
        public const string LCADD2 = "LCADD2";

        /// <summary>
        /// LCADD3.
        /// </summary>
        public const string LCADD3 = "LCADD3";

        /// <summary>
        /// LCADD4.
        /// </summary>
        public const string LCADD4 = "LCADD4";

        /// <summary>
        /// LCCTY1.
        /// </summary>
        public const string LCCTY1 = "LCCTY1";

        /// <summary>
        /// LCCOUN.
        /// </summary>
        public const string LCCOUN = "LCCOUN";

        /// <summary>
        /// LCADDS.
        /// </summary>
        public const string LCADDS = "LCADDS";

        /// <summary>
        /// LCADDZ.
        /// </summary>
        public const string LCADDZ = "LCADDZ";

        /// <summary>
        /// LCCTR.
        /// </summary>
        public const string LCCTR = "LCCTR";

        /// <summary>
        /// LCOTSPFLG.
        /// </summary>
        public const string LCOTSPFLG = "LCOTSPFLG";

        /// <summary>
        /// LCOTTRNCOD.
        /// </summary>
        public const string LCOTTRNCOD = "LCOTTRNCOD";

        /// <summary>
        /// LCOTDOMAIN.
        /// </summary>
        public const string LCOTDOMAIN = "LCOTDOMAIN";

        /// <summary>
        /// LCOTBATID.
        /// </summary>
        public const string LCOTBATID = "LCOTBATID";

        /// <summary>
        /// LCURCD.
        /// </summary>
        public const string LCURCD = "LCURCD";

        /// <summary>
        /// LCURDT.
        /// </summary>
        public const string LCURDT = "LCURDT";

        /// <summary>
        /// LCURRF.
        /// </summary>
        public const string LCURRF = "LCURRF";

        /// <summary>
        /// LCURAT.
        /// </summary>
        public const string LCURAT = "LCURAT";

        /// <summary>
        /// LCURAB.
        /// </summary>
        public const string LCURAB = "LCURAB";

        /// <summary>
        /// LCPID.
        /// </summary>
        public const string LCPID = "LCPID";

        /// <summary>
        /// LCTORG.
        /// </summary>
        public const string LCTORG = "LCTORG";

        /// <summary>
        /// LCUSER.
        /// </summary>
        public const string LCUSER = "LCUSER";

        /// <summary>
        /// LCJOBN.
        /// </summary>
        public const string LCJOBN = "LCJOBN";

        /// <summary>
        /// LCUUPMJ.
        /// </summary>
        public const string LCUUPMJ = "LCUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F49T80";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCAN8", "LCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("LCAT1", "LCAT1", JdeDataType.String, 6, true, true),
        new JdeField("LCOTLOCROL", "LCOTLOCROL", JdeDataType.String, 100),
        new JdeField("LCALPH", "LCALPH", JdeDataType.String, 80),
        new JdeField("LCPA8", "LCPA8", JdeDataType.Numeric),
        new JdeField("LCALPH2", "LCALPH2", JdeDataType.String, 80),
        new JdeField("LCCO", "LCCO", JdeDataType.String, 10),
        new JdeField("LCCRCD", "LCCRCD", JdeDataType.String, 6),
        new JdeField("LCADD1", "LCADD1", JdeDataType.String, 80),
        new JdeField("LCADD2", "LCADD2", JdeDataType.String, 80),
        new JdeField("LCADD3", "LCADD3", JdeDataType.String, 80),
        new JdeField("LCADD4", "LCADD4", JdeDataType.String, 80),
        new JdeField("LCCTY1", "LCCTY1", JdeDataType.String, 50),
        new JdeField("LCCOUN", "LCCOUN", JdeDataType.String, 50),
        new JdeField("LCADDS", "LCADDS", JdeDataType.String, 6),
        new JdeField("LCADDZ", "LCADDZ", JdeDataType.String, 24),
        new JdeField("LCCTR", "LCCTR", JdeDataType.String, 6),
        new JdeField("LCOTSPFLG", "LCOTSPFLG", JdeDataType.String, 4),
        new JdeField("LCOTTRNCOD", "LCOTTRNCOD", JdeDataType.String, 4),
        new JdeField("LCOTDOMAIN", "LCOTDOMAIN", JdeDataType.String, 100),
        new JdeField("LCOTBATID", "LCOTBATID", JdeDataType.Numeric),
        new JdeField("LCURCD", "LCURCD", JdeDataType.String, 4),
        new JdeField("LCURDT", "LCURDT", JdeDataType.Numeric),
        new JdeField("LCURRF", "LCURRF", JdeDataType.String, 30),
        new JdeField("LCURAT", "LCURAT", JdeDataType.Numeric),
        new JdeField("LCURAB", "LCURAB", JdeDataType.Numeric),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCTORG", "LCTORG", JdeDataType.String, 20),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCJOBN", "LCJOBN", JdeDataType.String, 20),
        new JdeField("LCUUPMJ", "LCUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49T80_0", "Primary Key on LCAN8, LCAT1", new[] { "LCAN8", "LCAT1" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49T80_2", "Index on LCOTBATID, LCAT1", new[] { "LCOTBATID", "LCAT1" })
    };
}
