using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4132 - .
/// </summary>
public class F4132 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UHUNUM.
        /// </summary>
        public const string UHUNUM = "UHUNUM";

        /// <summary>
        /// UHUTYPE.
        /// </summary>
        public const string UHUTYPE = "UHUTYPE";

        /// <summary>
        /// UHAN8.
        /// </summary>
        public const string UHAN8 = "UHAN8";

        /// <summary>
        /// UHSHAN.
        /// </summary>
        public const string UHSHAN = "UHSHAN";

        /// <summary>
        /// UHTOAN8.
        /// </summary>
        public const string UHTOAN8 = "UHTOAN8";

        /// <summary>
        /// UHTOSHAN.
        /// </summary>
        public const string UHTOSHAN = "UHTOSHAN";

        /// <summary>
        /// UHTRDJ.
        /// </summary>
        public const string UHTRDJ = "UHTRDJ";

        /// <summary>
        /// UHUSRCE.
        /// </summary>
        public const string UHUSRCE = "UHUSRCE";

        /// <summary>
        /// UHHOLD.
        /// </summary>
        public const string UHHOLD = "UHHOLD";

        /// <summary>
        /// UHTKBY.
        /// </summary>
        public const string UHTKBY = "UHTKBY";

        /// <summary>
        /// UHORBY.
        /// </summary>
        public const string UHORBY = "UHORBY";

        /// <summary>
        /// UHDEL1.
        /// </summary>
        public const string UHDEL1 = "UHDEL1";

        /// <summary>
        /// UHDEL2.
        /// </summary>
        public const string UHDEL2 = "UHDEL2";

        /// <summary>
        /// UHCARS.
        /// </summary>
        public const string UHCARS = "UHCARS";

        /// <summary>
        /// UHFRTH.
        /// </summary>
        public const string UHFRTH = "UHFRTH";

        /// <summary>
        /// UHROUT.
        /// </summary>
        public const string UHROUT = "UHROUT";

        /// <summary>
        /// UHSTOP.
        /// </summary>
        public const string UHSTOP = "UHSTOP";

        /// <summary>
        /// UHZON.
        /// </summary>
        public const string UHZON = "UHZON";

        /// <summary>
        /// UHMOT.
        /// </summary>
        public const string UHMOT = "UHMOT";

        /// <summary>
        /// UHTREX.
        /// </summary>
        public const string UHTREX = "UHTREX";

        /// <summary>
        /// UHSYNCS.
        /// </summary>
        public const string UHSYNCS = "UHSYNCS";

        /// <summary>
        /// UHURCD.
        /// </summary>
        public const string UHURCD = "UHURCD";

        /// <summary>
        /// UHURDT.
        /// </summary>
        public const string UHURDT = "UHURDT";

        /// <summary>
        /// UHURAT.
        /// </summary>
        public const string UHURAT = "UHURAT";

        /// <summary>
        /// UHURAB.
        /// </summary>
        public const string UHURAB = "UHURAB";

        /// <summary>
        /// UHURRF.
        /// </summary>
        public const string UHURRF = "UHURRF";

        /// <summary>
        /// UHURNUM01.
        /// </summary>
        public const string UHURNUM01 = "UHURNUM01";

        /// <summary>
        /// UHURNUM02.
        /// </summary>
        public const string UHURNUM02 = "UHURNUM02";

        /// <summary>
        /// UHUR06.
        /// </summary>
        public const string UHUR06 = "UHUR06";

        /// <summary>
        /// UHUR07.
        /// </summary>
        public const string UHUR07 = "UHUR07";

        /// <summary>
        /// UHUSER.
        /// </summary>
        public const string UHUSER = "UHUSER";

        /// <summary>
        /// UHPID.
        /// </summary>
        public const string UHPID = "UHPID";

        /// <summary>
        /// UHJOBN.
        /// </summary>
        public const string UHJOBN = "UHJOBN";

        /// <summary>
        /// UHUTIME.
        /// </summary>
        public const string UHUTIME = "UHUTIME";
    }

    /// <inheritdoc />
    public override string TableName => "F4132";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UHUNUM", "UHUNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("UHUTYPE", "UHUTYPE", JdeDataType.String, 4),
        new JdeField("UHAN8", "UHAN8", JdeDataType.Numeric),
        new JdeField("UHSHAN", "UHSHAN", JdeDataType.Numeric),
        new JdeField("UHTOAN8", "UHTOAN8", JdeDataType.Numeric),
        new JdeField("UHTOSHAN", "UHTOSHAN", JdeDataType.Numeric),
        new JdeField("UHTRDJ", "UHTRDJ", JdeDataType.Numeric),
        new JdeField("UHUSRCE", "UHUSRCE", JdeDataType.String, 2),
        new JdeField("UHHOLD", "UHHOLD", JdeDataType.String, 4),
        new JdeField("UHTKBY", "UHTKBY", JdeDataType.String, 20),
        new JdeField("UHORBY", "UHORBY", JdeDataType.String, 20),
        new JdeField("UHDEL1", "UHDEL1", JdeDataType.String, 60),
        new JdeField("UHDEL2", "UHDEL2", JdeDataType.String, 60),
        new JdeField("UHCARS", "UHCARS", JdeDataType.Numeric),
        new JdeField("UHFRTH", "UHFRTH", JdeDataType.String, 6),
        new JdeField("UHROUT", "UHROUT", JdeDataType.String, 6),
        new JdeField("UHSTOP", "UHSTOP", JdeDataType.String, 6),
        new JdeField("UHZON", "UHZON", JdeDataType.String, 6),
        new JdeField("UHMOT", "UHMOT", JdeDataType.String, 6),
        new JdeField("UHTREX", "UHTREX", JdeDataType.String, 60),
        new JdeField("UHSYNCS", "UHSYNCS", JdeDataType.Numeric),
        new JdeField("UHURCD", "UHURCD", JdeDataType.String, 4),
        new JdeField("UHURDT", "UHURDT", JdeDataType.Numeric),
        new JdeField("UHURAT", "UHURAT", JdeDataType.Numeric),
        new JdeField("UHURAB", "UHURAB", JdeDataType.Numeric),
        new JdeField("UHURRF", "UHURRF", JdeDataType.String, 30),
        new JdeField("UHURNUM01", "UHURNUM01", JdeDataType.Numeric),
        new JdeField("UHURNUM02", "UHURNUM02", JdeDataType.Numeric),
        new JdeField("UHUR06", "UHUR06", JdeDataType.String, 20),
        new JdeField("UHUR07", "UHUR07", JdeDataType.String, 20),
        new JdeField("UHUSER", "UHUSER", JdeDataType.String, 20),
        new JdeField("UHPID", "UHPID", JdeDataType.String, 20),
        new JdeField("UHJOBN", "UHJOBN", JdeDataType.String, 20),
        new JdeField("UHUTIME", "UHUTIME", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4132_0", "Primary Key on UHUNUM", new[] { "UHUNUM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4132_2", "Index on UHAN8, UHSHAN", new[] { "UHAN8", "UHSHAN" })
    };
}
