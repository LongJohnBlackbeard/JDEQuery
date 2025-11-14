using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49594 - .
/// </summary>
public class F49594 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DIBN01.
        /// </summary>
        public const string DIBN01 = "DIBN01";

        /// <summary>
        /// DIDCCD.
        /// </summary>
        public const string DIDCCD = "DIDCCD";

        /// <summary>
        /// DIMCUZ.
        /// </summary>
        public const string DIMCUZ = "DIMCUZ";

        /// <summary>
        /// DISDPC.
        /// </summary>
        public const string DISDPC = "DISDPC";

        /// <summary>
        /// DISEQN.
        /// </summary>
        public const string DISEQN = "DISEQN";

        /// <summary>
        /// DIDOCO.
        /// </summary>
        public const string DIDOCO = "DIDOCO";

        /// <summary>
        /// DIDCTO.
        /// </summary>
        public const string DIDCTO = "DIDCTO";

        /// <summary>
        /// DIKCOO.
        /// </summary>
        public const string DIKCOO = "DIKCOO";

        /// <summary>
        /// DILNID.
        /// </summary>
        public const string DILNID = "DILNID";

        /// <summary>
        /// DISRCO.
        /// </summary>
        public const string DISRCO = "DISRCO";

        /// <summary>
        /// DISHAN.
        /// </summary>
        public const string DISHAN = "DISHAN";

        /// <summary>
        /// DIDCRS.
        /// </summary>
        public const string DIDCRS = "DIDCRS";

        /// <summary>
        /// DIDCNS.
        /// </summary>
        public const string DIDCNS = "DIDCNS";

        /// <summary>
        /// DICO.
        /// </summary>
        public const string DICO = "DICO";

        /// <summary>
        /// DIEMCU.
        /// </summary>
        public const string DIEMCU = "DIEMCU";

        /// <summary>
        /// DIMCU.
        /// </summary>
        public const string DIMCU = "DIMCU";

        /// <summary>
        /// DIDCT.
        /// </summary>
        public const string DIDCT = "DIDCT";

        /// <summary>
        /// DIDOC.
        /// </summary>
        public const string DIDOC = "DIDOC";

        /// <summary>
        /// DIKCO.
        /// </summary>
        public const string DIKCO = "DIKCO";

        /// <summary>
        /// DIDTDO.
        /// </summary>
        public const string DIDTDO = "DIDTDO";

        /// <summary>
        /// DINXT2.
        /// </summary>
        public const string DINXT2 = "DINXT2";

        /// <summary>
        /// DILTT2.
        /// </summary>
        public const string DILTT2 = "DILTT2";

        /// <summary>
        /// DIRPKY.
        /// </summary>
        public const string DIRPKY = "DIRPKY";

        /// <summary>
        /// DIVMCU.
        /// </summary>
        public const string DIVMCU = "DIVMCU";

        /// <summary>
        /// DILDNM.
        /// </summary>
        public const string DILDNM = "DILDNM";

        /// <summary>
        /// DITRPL.
        /// </summary>
        public const string DITRPL = "DITRPL";

        /// <summary>
        /// DISHPN.
        /// </summary>
        public const string DISHPN = "DISHPN";

        /// <summary>
        /// DIRSSN.
        /// </summary>
        public const string DIRSSN = "DIRSSN";

        /// <summary>
        /// DIREFQ.
        /// </summary>
        public const string DIREFQ = "DIREFQ";

        /// <summary>
        /// DIREFN.
        /// </summary>
        public const string DIREFN = "DIREFN";

        /// <summary>
        /// DIURCD.
        /// </summary>
        public const string DIURCD = "DIURCD";

        /// <summary>
        /// DIURDT.
        /// </summary>
        public const string DIURDT = "DIURDT";

        /// <summary>
        /// DIURAT.
        /// </summary>
        public const string DIURAT = "DIURAT";

        /// <summary>
        /// DIURAB.
        /// </summary>
        public const string DIURAB = "DIURAB";

        /// <summary>
        /// DIURRF.
        /// </summary>
        public const string DIURRF = "DIURRF";

        /// <summary>
        /// DIUSER.
        /// </summary>
        public const string DIUSER = "DIUSER";

        /// <summary>
        /// DIPID.
        /// </summary>
        public const string DIPID = "DIPID";

        /// <summary>
        /// DIJOBN.
        /// </summary>
        public const string DIJOBN = "DIJOBN";

        /// <summary>
        /// DIUPMJ.
        /// </summary>
        public const string DIUPMJ = "DIUPMJ";

        /// <summary>
        /// DITDAY.
        /// </summary>
        public const string DITDAY = "DITDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49594";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DIBN01", "DIBN01", JdeDataType.Numeric, null, true, true),
        new JdeField("DIDCCD", "DIDCCD", JdeDataType.String, 8, true, true),
        new JdeField("DIMCUZ", "DIMCUZ", JdeDataType.String, 24, true, true),
        new JdeField("DISDPC", "DISDPC", JdeDataType.String, 2),
        new JdeField("DISEQN", "DISEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("DIDOCO", "DIDOCO", JdeDataType.Numeric),
        new JdeField("DIDCTO", "DIDCTO", JdeDataType.String, 4),
        new JdeField("DIKCOO", "DIKCOO", JdeDataType.String, 10),
        new JdeField("DILNID", "DILNID", JdeDataType.Numeric),
        new JdeField("DISRCO", "DISRCO", JdeDataType.String, 2),
        new JdeField("DISHAN", "DISHAN", JdeDataType.Numeric),
        new JdeField("DIDCRS", "DIDCRS", JdeDataType.String, 4),
        new JdeField("DIDCNS", "DIDCNS", JdeDataType.String, 2),
        new JdeField("DICO", "DICO", JdeDataType.String, 10),
        new JdeField("DIEMCU", "DIEMCU", JdeDataType.String, 24),
        new JdeField("DIMCU", "DIMCU", JdeDataType.String, 24),
        new JdeField("DIDCT", "DIDCT", JdeDataType.String, 4),
        new JdeField("DIDOC", "DIDOC", JdeDataType.Numeric),
        new JdeField("DIKCO", "DIKCO", JdeDataType.String, 10),
        new JdeField("DIDTDO", "DIDTDO", JdeDataType.Numeric),
        new JdeField("DINXT2", "DINXT2", JdeDataType.String, 6),
        new JdeField("DILTT2", "DILTT2", JdeDataType.String, 6),
        new JdeField("DIRPKY", "DIRPKY", JdeDataType.Numeric),
        new JdeField("DIVMCU", "DIVMCU", JdeDataType.String, 24),
        new JdeField("DILDNM", "DILDNM", JdeDataType.Numeric),
        new JdeField("DITRPL", "DITRPL", JdeDataType.Numeric),
        new JdeField("DISHPN", "DISHPN", JdeDataType.Numeric),
        new JdeField("DIRSSN", "DIRSSN", JdeDataType.Numeric),
        new JdeField("DIREFQ", "DIREFQ", JdeDataType.String, 4),
        new JdeField("DIREFN", "DIREFN", JdeDataType.String, 60),
        new JdeField("DIURCD", "DIURCD", JdeDataType.String, 4),
        new JdeField("DIURDT", "DIURDT", JdeDataType.Numeric),
        new JdeField("DIURAT", "DIURAT", JdeDataType.Numeric),
        new JdeField("DIURAB", "DIURAB", JdeDataType.Numeric),
        new JdeField("DIURRF", "DIURRF", JdeDataType.String, 30),
        new JdeField("DIUSER", "DIUSER", JdeDataType.String, 20),
        new JdeField("DIPID", "DIPID", JdeDataType.String, 20),
        new JdeField("DIJOBN", "DIJOBN", JdeDataType.String, 20),
        new JdeField("DIUPMJ", "DIUPMJ", JdeDataType.Numeric),
        new JdeField("DITDAY", "DITDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49594_0", "Primary Key on DIBN01, DIMCUZ, DIDCCD, DISEQN", new[] { "DIBN01", "DIMCUZ", "DIDCCD", "DISEQN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49594_2", "Index on DIBN01, DIMCUZ, DIDCCD, DIDCT, DIDOC", new[] { "DIBN01", "DIMCUZ", "DIDCCD", "DIDCT", "DIDOC" })
    };
}
