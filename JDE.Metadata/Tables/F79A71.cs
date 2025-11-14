using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A71 - .
/// </summary>
public class F79A71 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GO79AGOID.
        /// </summary>
        public const string GO79AGOID = "GO79AGOID";

        /// <summary>
        /// GO79AGOCD.
        /// </summary>
        public const string GO79AGOCD = "GO79AGOCD";

        /// <summary>
        /// GO79AGOT.
        /// </summary>
        public const string GO79AGOT = "GO79AGOT";

        /// <summary>
        /// GO79AGFS.
        /// </summary>
        public const string GO79AGFS = "GO79AGFS";

        /// <summary>
        /// GO79AANZ.
        /// </summary>
        public const string GO79AANZ = "GO79AANZ";

        /// <summary>
        /// GO79ALAT.
        /// </summary>
        public const string GO79ALAT = "GO79ALAT";

        /// <summary>
        /// GO79ALON.
        /// </summary>
        public const string GO79ALON = "GO79ALON";

        /// <summary>
        /// GO79AOLOC.
        /// </summary>
        public const string GO79AOLOC = "GO79AOLOC";

        /// <summary>
        /// GO79AGOBN.
        /// </summary>
        public const string GO79AGOBN = "GO79AGOBN";

        /// <summary>
        /// GO79AGCN.
        /// </summary>
        public const string GO79AGCN = "GO79AGCN";

        /// <summary>
        /// GOAN8.
        /// </summary>
        public const string GOAN8 = "GOAN8";

        /// <summary>
        /// GOBEFD.
        /// </summary>
        public const string GOBEFD = "GOBEFD";

        /// <summary>
        /// GOEEFD.
        /// </summary>
        public const string GOEEFD = "GOEEFD";

        /// <summary>
        /// GO79AF01.
        /// </summary>
        public const string GO79AF01 = "GO79AF01";

        /// <summary>
        /// GO79AF02.
        /// </summary>
        public const string GO79AF02 = "GO79AF02";

        /// <summary>
        /// GO79AF03.
        /// </summary>
        public const string GO79AF03 = "GO79AF03";

        /// <summary>
        /// GO79AF04.
        /// </summary>
        public const string GO79AF04 = "GO79AF04";

        /// <summary>
        /// GO79AF05.
        /// </summary>
        public const string GO79AF05 = "GO79AF05";

        /// <summary>
        /// GO79AF06.
        /// </summary>
        public const string GO79AF06 = "GO79AF06";

        /// <summary>
        /// GO79AF07.
        /// </summary>
        public const string GO79AF07 = "GO79AF07";

        /// <summary>
        /// GO79AF08.
        /// </summary>
        public const string GO79AF08 = "GO79AF08";

        /// <summary>
        /// GO79AF09.
        /// </summary>
        public const string GO79AF09 = "GO79AF09";

        /// <summary>
        /// GO79AF10.
        /// </summary>
        public const string GO79AF10 = "GO79AF10";

        /// <summary>
        /// GO79AF11.
        /// </summary>
        public const string GO79AF11 = "GO79AF11";

        /// <summary>
        /// GO79AF12.
        /// </summary>
        public const string GO79AF12 = "GO79AF12";

        /// <summary>
        /// GO79AF13.
        /// </summary>
        public const string GO79AF13 = "GO79AF13";

        /// <summary>
        /// GO79AF14.
        /// </summary>
        public const string GO79AF14 = "GO79AF14";

        /// <summary>
        /// GO79AF15.
        /// </summary>
        public const string GO79AF15 = "GO79AF15";

        /// <summary>
        /// GO79AF16.
        /// </summary>
        public const string GO79AF16 = "GO79AF16";

        /// <summary>
        /// GO79AF17.
        /// </summary>
        public const string GO79AF17 = "GO79AF17";

        /// <summary>
        /// GO79AF18.
        /// </summary>
        public const string GO79AF18 = "GO79AF18";

        /// <summary>
        /// GO79AF19.
        /// </summary>
        public const string GO79AF19 = "GO79AF19";

        /// <summary>
        /// GO79AF20.
        /// </summary>
        public const string GO79AF20 = "GO79AF20";

        /// <summary>
        /// GO79AF21.
        /// </summary>
        public const string GO79AF21 = "GO79AF21";

        /// <summary>
        /// GO79AF22.
        /// </summary>
        public const string GO79AF22 = "GO79AF22";

        /// <summary>
        /// GO79AF23.
        /// </summary>
        public const string GO79AF23 = "GO79AF23";

        /// <summary>
        /// GO79AF24.
        /// </summary>
        public const string GO79AF24 = "GO79AF24";

        /// <summary>
        /// GO79AF25.
        /// </summary>
        public const string GO79AF25 = "GO79AF25";

        /// <summary>
        /// GO79AF26.
        /// </summary>
        public const string GO79AF26 = "GO79AF26";

        /// <summary>
        /// GO79AF27.
        /// </summary>
        public const string GO79AF27 = "GO79AF27";

        /// <summary>
        /// GO79AF28.
        /// </summary>
        public const string GO79AF28 = "GO79AF28";

        /// <summary>
        /// GO79AF29.
        /// </summary>
        public const string GO79AF29 = "GO79AF29";

        /// <summary>
        /// GO79AF30.
        /// </summary>
        public const string GO79AF30 = "GO79AF30";

        /// <summary>
        /// GOPID.
        /// </summary>
        public const string GOPID = "GOPID";

        /// <summary>
        /// GOUSER.
        /// </summary>
        public const string GOUSER = "GOUSER";

        /// <summary>
        /// GOJOBN.
        /// </summary>
        public const string GOJOBN = "GOJOBN";

        /// <summary>
        /// GOUPMJ.
        /// </summary>
        public const string GOUPMJ = "GOUPMJ";

        /// <summary>
        /// GOTDAY.
        /// </summary>
        public const string GOTDAY = "GOTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F79A71";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GO79AGOID", "GO79AGOID", JdeDataType.Numeric, null, true, true),
        new JdeField("GO79AGOCD", "GO79AGOCD", JdeDataType.String, 120),
        new JdeField("GO79AGOT", "GO79AGOT", JdeDataType.String, 200),
        new JdeField("GO79AGFS", "GO79AGFS", JdeDataType.String, 4),
        new JdeField("GO79AANZ", "GO79AANZ", JdeDataType.String, 12),
        new JdeField("GO79ALAT", "GO79ALAT", JdeDataType.String, 40),
        new JdeField("GO79ALON", "GO79ALON", JdeDataType.String, 40),
        new JdeField("GO79AOLOC", "GO79AOLOC", JdeDataType.String, 200),
        new JdeField("GO79AGOBN", "GO79AGOBN", JdeDataType.String, 60),
        new JdeField("GO79AGCN", "GO79AGCN", JdeDataType.String, 200),
        new JdeField("GOAN8", "GOAN8", JdeDataType.Numeric),
        new JdeField("GOBEFD", "GOBEFD", JdeDataType.Numeric),
        new JdeField("GOEEFD", "GOEEFD", JdeDataType.Numeric),
        new JdeField("GO79AF01", "GO79AF01", JdeDataType.String, 30),
        new JdeField("GO79AF02", "GO79AF02", JdeDataType.String, 30),
        new JdeField("GO79AF03", "GO79AF03", JdeDataType.String, 30),
        new JdeField("GO79AF04", "GO79AF04", JdeDataType.String, 30),
        new JdeField("GO79AF05", "GO79AF05", JdeDataType.String, 30),
        new JdeField("GO79AF06", "GO79AF06", JdeDataType.String, 30),
        new JdeField("GO79AF07", "GO79AF07", JdeDataType.String, 30),
        new JdeField("GO79AF08", "GO79AF08", JdeDataType.String, 30),
        new JdeField("GO79AF09", "GO79AF09", JdeDataType.String, 30),
        new JdeField("GO79AF10", "GO79AF10", JdeDataType.String, 30),
        new JdeField("GO79AF11", "GO79AF11", JdeDataType.String, 30),
        new JdeField("GO79AF12", "GO79AF12", JdeDataType.String, 30),
        new JdeField("GO79AF13", "GO79AF13", JdeDataType.String, 30),
        new JdeField("GO79AF14", "GO79AF14", JdeDataType.String, 30),
        new JdeField("GO79AF15", "GO79AF15", JdeDataType.String, 30),
        new JdeField("GO79AF16", "GO79AF16", JdeDataType.String, 30),
        new JdeField("GO79AF17", "GO79AF17", JdeDataType.String, 30),
        new JdeField("GO79AF18", "GO79AF18", JdeDataType.String, 30),
        new JdeField("GO79AF19", "GO79AF19", JdeDataType.String, 30),
        new JdeField("GO79AF20", "GO79AF20", JdeDataType.String, 30),
        new JdeField("GO79AF21", "GO79AF21", JdeDataType.String, 30),
        new JdeField("GO79AF22", "GO79AF22", JdeDataType.String, 30),
        new JdeField("GO79AF23", "GO79AF23", JdeDataType.String, 30),
        new JdeField("GO79AF24", "GO79AF24", JdeDataType.String, 30),
        new JdeField("GO79AF25", "GO79AF25", JdeDataType.String, 30),
        new JdeField("GO79AF26", "GO79AF26", JdeDataType.String, 30),
        new JdeField("GO79AF27", "GO79AF27", JdeDataType.String, 30),
        new JdeField("GO79AF28", "GO79AF28", JdeDataType.String, 30),
        new JdeField("GO79AF29", "GO79AF29", JdeDataType.String, 30),
        new JdeField("GO79AF30", "GO79AF30", JdeDataType.String, 30),
        new JdeField("GOPID", "GOPID", JdeDataType.String, 20),
        new JdeField("GOUSER", "GOUSER", JdeDataType.String, 20),
        new JdeField("GOJOBN", "GOJOBN", JdeDataType.String, 20),
        new JdeField("GOUPMJ", "GOUPMJ", JdeDataType.Numeric),
        new JdeField("GOTDAY", "GOTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A71_0", "Primary Key on GO79AGOID", new[] { "GO79AGOID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79A71_2", "Index on GO79AGOCD, GOBEFD", new[] { "GO79AGOCD", "GOBEFD" }),
        new JdeIndex("F79A71_3", "Index on GOBEFD", new[] { "GOBEFD" }),
        new JdeIndex("F79A71_4", "Index on GO79AGOBN", new[] { "GO79AGOBN" }),
        new JdeIndex("F79A71_5", "Index on GO79AGCN", new[] { "GO79AGCN" }),
        new JdeIndex("F79A71_6", "Index on GO79AGOT, GOBEFD", new[] { "GO79AGOT", "GOBEFD" }),
        new JdeIndex("F79A71_7", "Index on GO79AGOCD, GO79AGOT", new[] { "GO79AGOCD", "GO79AGOT" }),
        new JdeIndex("F79A71_8", "Unique Index on GO79AGOCD", new[] { "GO79AGOCD" }, isUnique: true)
    };
}
