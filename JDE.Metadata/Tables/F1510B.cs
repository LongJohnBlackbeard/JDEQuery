using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1510B - .
/// </summary>
public class F1510B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OECO.
        /// </summary>
        public const string OECO = "OECO";

        /// <summary>
        /// OEMCU.
        /// </summary>
        public const string OEMCU = "OEMCU";

        /// <summary>
        /// OEICRR.
        /// </summary>
        public const string OEICRR = "OEICRR";

        /// <summary>
        /// OEIARR.
        /// </summary>
        public const string OEIARR = "OEIARR";

        /// <summary>
        /// OELYBM.
        /// </summary>
        public const string OELYBM = "OELYBM";

        /// <summary>
        /// OERYBM.
        /// </summary>
        public const string OERYBM = "OERYBM";

        /// <summary>
        /// OERCCF.
        /// </summary>
        public const string OERCCF = "OERCCF";

        /// <summary>
        /// OEICBC.
        /// </summary>
        public const string OEICBC = "OEICBC";

        /// <summary>
        /// OEFG01.
        /// </summary>
        public const string OEFG01 = "OEFG01";

        /// <summary>
        /// OEFG02.
        /// </summary>
        public const string OEFG02 = "OEFG02";

        /// <summary>
        /// OEFG03.
        /// </summary>
        public const string OEFG03 = "OEFG03";

        /// <summary>
        /// OEFG04.
        /// </summary>
        public const string OEFG04 = "OEFG04";

        /// <summary>
        /// OEFG05.
        /// </summary>
        public const string OEFG05 = "OEFG05";

        /// <summary>
        /// OEFG06.
        /// </summary>
        public const string OEFG06 = "OEFG06";

        /// <summary>
        /// OEFG07.
        /// </summary>
        public const string OEFG07 = "OEFG07";

        /// <summary>
        /// OEFG08.
        /// </summary>
        public const string OEFG08 = "OEFG08";

        /// <summary>
        /// OEFG09.
        /// </summary>
        public const string OEFG09 = "OEFG09";

        /// <summary>
        /// OEFG10.
        /// </summary>
        public const string OEFG10 = "OEFG10";

        /// <summary>
        /// OERNAT.
        /// </summary>
        public const string OERNAT = "OERNAT";

        /// <summary>
        /// OEUSAT.
        /// </summary>
        public const string OEUSAT = "OEUSAT";

        /// <summary>
        /// OEAAT1.
        /// </summary>
        public const string OEAAT1 = "OEAAT1";

        /// <summary>
        /// OEAAT2.
        /// </summary>
        public const string OEAAT2 = "OEAAT2";

        /// <summary>
        /// OEAAT3.
        /// </summary>
        public const string OEAAT3 = "OEAAT3";

        /// <summary>
        /// OERNTV.
        /// </summary>
        public const string OERNTV = "OERNTV";

        /// <summary>
        /// OEUSEV.
        /// </summary>
        public const string OEUSEV = "OEUSEV";

        /// <summary>
        /// OEAT1V.
        /// </summary>
        public const string OEAT1V = "OEAT1V";

        /// <summary>
        /// OEAT2V.
        /// </summary>
        public const string OEAT2V = "OEAT2V";

        /// <summary>
        /// OEAT3V.
        /// </summary>
        public const string OEAT3V = "OEAT3V";

        /// <summary>
        /// OEVRDF.
        /// </summary>
        public const string OEVRDF = "OEVRDF";

        /// <summary>
        /// OEVRFL.
        /// </summary>
        public const string OEVRFL = "OEVRFL";

        /// <summary>
        /// OEVRER.
        /// </summary>
        public const string OEVRER = "OEVRER";

        /// <summary>
        /// OEURCD.
        /// </summary>
        public const string OEURCD = "OEURCD";

        /// <summary>
        /// OEURDT.
        /// </summary>
        public const string OEURDT = "OEURDT";

        /// <summary>
        /// OEURAT.
        /// </summary>
        public const string OEURAT = "OEURAT";

        /// <summary>
        /// OEURAB.
        /// </summary>
        public const string OEURAB = "OEURAB";

        /// <summary>
        /// OEURRF.
        /// </summary>
        public const string OEURRF = "OEURRF";

        /// <summary>
        /// OEUSER.
        /// </summary>
        public const string OEUSER = "OEUSER";

        /// <summary>
        /// OEPID.
        /// </summary>
        public const string OEPID = "OEPID";

        /// <summary>
        /// OEUPMJ.
        /// </summary>
        public const string OEUPMJ = "OEUPMJ";

        /// <summary>
        /// OEUPMT.
        /// </summary>
        public const string OEUPMT = "OEUPMT";

        /// <summary>
        /// OEJOBN.
        /// </summary>
        public const string OEJOBN = "OEJOBN";

        /// <summary>
        /// OEENTJ.
        /// </summary>
        public const string OEENTJ = "OEENTJ";

        /// <summary>
        /// OETORG.
        /// </summary>
        public const string OETORG = "OETORG";

        /// <summary>
        /// OELAFLTD.
        /// </summary>
        public const string OELAFLTD = "OELAFLTD";

        /// <summary>
        /// OELABEOA.
        /// </summary>
        public const string OELABEOA = "OELABEOA";

        /// <summary>
        /// OELALVS.
        /// </summary>
        public const string OELALVS = "OELALVS";

        /// <summary>
        /// OELELC.
        /// </summary>
        public const string OELELC = "OELELC";

        /// <summary>
        /// OELERCEO.
        /// </summary>
        public const string OELERCEO = "OELERCEO";

        /// <summary>
        /// OELEGUA.
        /// </summary>
        public const string OELEGUA = "OELEGUA";

        /// <summary>
        /// OELEAAI.
        /// </summary>
        public const string OELEAAI = "OELEAAI";
    }

    /// <inheritdoc />
    public override string TableName => "F1510B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OECO", "OECO", JdeDataType.String, 10, true, true),
        new JdeField("OEMCU", "OEMCU", JdeDataType.String, 24, true, true),
        new JdeField("OEICRR", "OEICRR", JdeDataType.String, 2),
        new JdeField("OEIARR", "OEIARR", JdeDataType.String, 2),
        new JdeField("OELYBM", "OELYBM", JdeDataType.Numeric),
        new JdeField("OERYBM", "OERYBM", JdeDataType.Numeric),
        new JdeField("OERCCF", "OERCCF", JdeDataType.String, 2),
        new JdeField("OEICBC", "OEICBC", JdeDataType.String, 4),
        new JdeField("OEFG01", "OEFG01", JdeDataType.String, 2),
        new JdeField("OEFG02", "OEFG02", JdeDataType.String, 2),
        new JdeField("OEFG03", "OEFG03", JdeDataType.String, 2),
        new JdeField("OEFG04", "OEFG04", JdeDataType.String, 2),
        new JdeField("OEFG05", "OEFG05", JdeDataType.String, 2),
        new JdeField("OEFG06", "OEFG06", JdeDataType.String, 2),
        new JdeField("OEFG07", "OEFG07", JdeDataType.String, 2),
        new JdeField("OEFG08", "OEFG08", JdeDataType.String, 2),
        new JdeField("OEFG09", "OEFG09", JdeDataType.String, 2),
        new JdeField("OEFG10", "OEFG10", JdeDataType.String, 2),
        new JdeField("OERNAT", "OERNAT", JdeDataType.String, 6),
        new JdeField("OEUSAT", "OEUSAT", JdeDataType.String, 6),
        new JdeField("OEAAT1", "OEAAT1", JdeDataType.String, 6),
        new JdeField("OEAAT2", "OEAAT2", JdeDataType.String, 6),
        new JdeField("OEAAT3", "OEAAT3", JdeDataType.String, 6),
        new JdeField("OERNTV", "OERNTV", JdeDataType.String, 2),
        new JdeField("OEUSEV", "OEUSEV", JdeDataType.String, 2),
        new JdeField("OEAT1V", "OEAT1V", JdeDataType.String, 2),
        new JdeField("OEAT2V", "OEAT2V", JdeDataType.String, 2),
        new JdeField("OEAT3V", "OEAT3V", JdeDataType.String, 2),
        new JdeField("OEVRDF", "OEVRDF", JdeDataType.String, 20),
        new JdeField("OEVRFL", "OEVRFL", JdeDataType.String, 2),
        new JdeField("OEVRER", "OEVRER", JdeDataType.String, 2),
        new JdeField("OEURCD", "OEURCD", JdeDataType.String, 4),
        new JdeField("OEURDT", "OEURDT", JdeDataType.Numeric),
        new JdeField("OEURAT", "OEURAT", JdeDataType.Numeric),
        new JdeField("OEURAB", "OEURAB", JdeDataType.Numeric),
        new JdeField("OEURRF", "OEURRF", JdeDataType.String, 30),
        new JdeField("OEUSER", "OEUSER", JdeDataType.String, 20),
        new JdeField("OEPID", "OEPID", JdeDataType.String, 20),
        new JdeField("OEUPMJ", "OEUPMJ", JdeDataType.Numeric),
        new JdeField("OEUPMT", "OEUPMT", JdeDataType.Numeric),
        new JdeField("OEJOBN", "OEJOBN", JdeDataType.String, 20),
        new JdeField("OEENTJ", "OEENTJ", JdeDataType.Numeric),
        new JdeField("OETORG", "OETORG", JdeDataType.String, 20),
        new JdeField("OELAFLTD", "OELAFLTD", JdeDataType.String, 2),
        new JdeField("OELABEOA", "OELABEOA", JdeDataType.String, 2),
        new JdeField("OELALVS", "OELALVS", JdeDataType.String, 2),
        new JdeField("OELELC", "OELELC", JdeDataType.String, 2),
        new JdeField("OELERCEO", "OELERCEO", JdeDataType.String, 2),
        new JdeField("OELEGUA", "OELEGUA", JdeDataType.String, 2),
        new JdeField("OELEAAI", "OELEAAI", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1510B_0", "Primary Key on OECO, OEMCU", new[] { "OECO", "OEMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
