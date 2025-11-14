using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08320 - .
/// </summary>
public class F08320 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BAPLAN.
        /// </summary>
        public const string BAPLAN = "BAPLAN";

        /// <summary>
        /// BAEXA.
        /// </summary>
        public const string BAEXA = "BAEXA";

        /// <summary>
        /// BADC.
        /// </summary>
        public const string BADC = "BADC";

        /// <summary>
        /// BAANN8.
        /// </summary>
        public const string BAANN8 = "BAANN8";

        /// <summary>
        /// BAEFT.
        /// </summary>
        public const string BAEFT = "BAEFT";

        /// <summary>
        /// BAEFTE.
        /// </summary>
        public const string BAEFTE = "BAEFTE";

        /// <summary>
        /// BASTUS.
        /// </summary>
        public const string BASTUS = "BASTUS";

        /// <summary>
        /// BAPLTY.
        /// </summary>
        public const string BAPLTY = "BAPLTY";

        /// <summary>
        /// BABENF.
        /// </summary>
        public const string BABENF = "BABENF";

        /// <summary>
        /// BACERN.
        /// </summary>
        public const string BACERN = "BACERN";

        /// <summary>
        /// BACOVA.
        /// </summary>
        public const string BACOVA = "BACOVA";

        /// <summary>
        /// BAPREP.
        /// </summary>
        public const string BAPREP = "BAPREP";

        /// <summary>
        /// BAVTAB.
        /// </summary>
        public const string BAVTAB = "BAVTAB";

        /// <summary>
        /// BAEDBA.
        /// </summary>
        public const string BAEDBA = "BAEDBA";

        /// <summary>
        /// BAFDBA.
        /// </summary>
        public const string BAFDBA = "BAFDBA";

        /// <summary>
        /// BARDBA.
        /// </summary>
        public const string BARDBA = "BARDBA";

        /// <summary>
        /// BASDBA.
        /// </summary>
        public const string BASDBA = "BASDBA";

        /// <summary>
        /// BAMANP.
        /// </summary>
        public const string BAMANP = "BAMANP";

        /// <summary>
        /// BAPCDO.
        /// </summary>
        public const string BAPCDO = "BAPCDO";

        /// <summary>
        /// BASALF.
        /// </summary>
        public const string BASALF = "BASALF";

        /// <summary>
        /// BADTAB.
        /// </summary>
        public const string BADTAB = "BADTAB";

        /// <summary>
        /// BAPDDP.
        /// </summary>
        public const string BAPDDP = "BAPDDP";

        /// <summary>
        /// BAPDCP.
        /// </summary>
        public const string BAPDCP = "BAPDCP";

        /// <summary>
        /// BADPYN.
        /// </summary>
        public const string BADPYN = "BADPYN";

        /// <summary>
        /// BAVCRL.
        /// </summary>
        public const string BAVCRL = "BAVCRL";

        /// <summary>
        /// BAPTVH.
        /// </summary>
        public const string BAPTVH = "BAPTVH";

        /// <summary>
        /// BAVSMH.
        /// </summary>
        public const string BAVSMH = "BAVSMH";

        /// <summary>
        /// BAVCPE.
        /// </summary>
        public const string BAVCPE = "BAVCPE";

        /// <summary>
        /// BAPH01.
        /// </summary>
        public const string BAPH01 = "BAPH01";

        /// <summary>
        /// BAPH02.
        /// </summary>
        public const string BAPH02 = "BAPH02";

        /// <summary>
        /// BAPH03.
        /// </summary>
        public const string BAPH03 = "BAPH03";

        /// <summary>
        /// BAPH04.
        /// </summary>
        public const string BAPH04 = "BAPH04";

        /// <summary>
        /// BAPH05.
        /// </summary>
        public const string BAPH05 = "BAPH05";

        /// <summary>
        /// BAPH06.
        /// </summary>
        public const string BAPH06 = "BAPH06";

        /// <summary>
        /// BAPH07.
        /// </summary>
        public const string BAPH07 = "BAPH07";

        /// <summary>
        /// BAPH08.
        /// </summary>
        public const string BAPH08 = "BAPH08";

        /// <summary>
        /// BAPH09.
        /// </summary>
        public const string BAPH09 = "BAPH09";

        /// <summary>
        /// BAPH10.
        /// </summary>
        public const string BAPH10 = "BAPH10";

        /// <summary>
        /// BAUSER.
        /// </summary>
        public const string BAUSER = "BAUSER";

        /// <summary>
        /// BAPID.
        /// </summary>
        public const string BAPID = "BAPID";

        /// <summary>
        /// BAUPMJ.
        /// </summary>
        public const string BAUPMJ = "BAUPMJ";

        /// <summary>
        /// BAJOBN.
        /// </summary>
        public const string BAJOBN = "BAJOBN";

        /// <summary>
        /// BAXET1.
        /// </summary>
        public const string BAXET1 = "BAXET1";

        /// <summary>
        /// BAXET2.
        /// </summary>
        public const string BAXET2 = "BAXET2";

        /// <summary>
        /// BAEAOR.
        /// </summary>
        public const string BAEAOR = "BAEAOR";

        /// <summary>
        /// BAARFL.
        /// </summary>
        public const string BAARFL = "BAARFL";

        /// <summary>
        /// BAPPLN.
        /// </summary>
        public const string BAPPLN = "BAPPLN";

        /// <summary>
        /// BAMXPR.
        /// </summary>
        public const string BAMXPR = "BAMXPR";

        /// <summary>
        /// BARNDA.
        /// </summary>
        public const string BARNDA = "BARNDA";

        /// <summary>
        /// BACBRA.
        /// </summary>
        public const string BACBRA = "BACBRA";

        /// <summary>
        /// BAPLN2.
        /// </summary>
        public const string BAPLN2 = "BAPLN2";

        /// <summary>
        /// BAFSAF.
        /// </summary>
        public const string BAFSAF = "BAFSAF";

        /// <summary>
        /// BAPAYF.
        /// </summary>
        public const string BAPAYF = "BAPAYF";

        /// <summary>
        /// BAFLXA.
        /// </summary>
        public const string BAFLXA = "BAFLXA";

        /// <summary>
        /// BAPLTZ.
        /// </summary>
        public const string BAPLTZ = "BAPLTZ";

        /// <summary>
        /// BAEFL1.
        /// </summary>
        public const string BAEFL1 = "BAEFL1";

        /// <summary>
        /// BAEFL2.
        /// </summary>
        public const string BAEFL2 = "BAEFL2";

        /// <summary>
        /// BAEFL3.
        /// </summary>
        public const string BAEFL3 = "BAEFL3";

        /// <summary>
        /// BAEFL4.
        /// </summary>
        public const string BAEFL4 = "BAEFL4";

        /// <summary>
        /// BAEFP1.
        /// </summary>
        public const string BAEFP1 = "BAEFP1";

        /// <summary>
        /// BAEFP2.
        /// </summary>
        public const string BAEFP2 = "BAEFP2";

        /// <summary>
        /// BAEFP3.
        /// </summary>
        public const string BAEFP3 = "BAEFP3";

        /// <summary>
        /// BAEFP4.
        /// </summary>
        public const string BAEFP4 = "BAEFP4";

        /// <summary>
        /// BAEFR1.
        /// </summary>
        public const string BAEFR1 = "BAEFR1";

        /// <summary>
        /// BAEFR2.
        /// </summary>
        public const string BAEFR2 = "BAEFR2";

        /// <summary>
        /// BAEFR3.
        /// </summary>
        public const string BAEFR3 = "BAEFR3";

        /// <summary>
        /// BAEFR4.
        /// </summary>
        public const string BAEFR4 = "BAEFR4";
    }

    /// <inheritdoc />
    public override string TableName => "F08320";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BAPLAN", "BAPLAN", JdeDataType.String, 16, true, true),
        new JdeField("BAEXA", "BAEXA", JdeDataType.String, 60),
        new JdeField("BADC", "BADC", JdeDataType.String, 80),
        new JdeField("BAANN8", "BAANN8", JdeDataType.Numeric),
        new JdeField("BAEFT", "BAEFT", JdeDataType.Numeric),
        new JdeField("BAEFTE", "BAEFTE", JdeDataType.Numeric),
        new JdeField("BASTUS", "BASTUS", JdeDataType.String, 2),
        new JdeField("BAPLTY", "BAPLTY", JdeDataType.String, 4),
        new JdeField("BABENF", "BABENF", JdeDataType.String, 2),
        new JdeField("BACERN", "BACERN", JdeDataType.String, 60),
        new JdeField("BACOVA", "BACOVA", JdeDataType.Numeric),
        new JdeField("BAPREP", "BAPREP", JdeDataType.Numeric),
        new JdeField("BAVTAB", "BAVTAB", JdeDataType.String, 10),
        new JdeField("BAEDBA", "BAEDBA", JdeDataType.Numeric),
        new JdeField("BAFDBA", "BAFDBA", JdeDataType.Numeric),
        new JdeField("BARDBA", "BARDBA", JdeDataType.Numeric),
        new JdeField("BASDBA", "BASDBA", JdeDataType.Numeric),
        new JdeField("BAMANP", "BAMANP", JdeDataType.String, 2),
        new JdeField("BAPCDO", "BAPCDO", JdeDataType.Numeric),
        new JdeField("BASALF", "BASALF", JdeDataType.Numeric),
        new JdeField("BADTAB", "BADTAB", JdeDataType.String, 10),
        new JdeField("BAPDDP", "BAPDDP", JdeDataType.Numeric),
        new JdeField("BAPDCP", "BAPDCP", JdeDataType.Numeric),
        new JdeField("BADPYN", "BADPYN", JdeDataType.String, 2),
        new JdeField("BAVCRL", "BAVCRL", JdeDataType.String, 4),
        new JdeField("BAPTVH", "BAPTVH", JdeDataType.String, 8),
        new JdeField("BAVSMH", "BAVSMH", JdeDataType.Numeric),
        new JdeField("BAVCPE", "BAVCPE", JdeDataType.String, 2),
        new JdeField("BAPH01", "BAPH01", JdeDataType.String, 6),
        new JdeField("BAPH02", "BAPH02", JdeDataType.String, 6),
        new JdeField("BAPH03", "BAPH03", JdeDataType.String, 6),
        new JdeField("BAPH04", "BAPH04", JdeDataType.String, 6),
        new JdeField("BAPH05", "BAPH05", JdeDataType.String, 6),
        new JdeField("BAPH06", "BAPH06", JdeDataType.String, 6),
        new JdeField("BAPH07", "BAPH07", JdeDataType.String, 6),
        new JdeField("BAPH08", "BAPH08", JdeDataType.String, 6),
        new JdeField("BAPH09", "BAPH09", JdeDataType.String, 6),
        new JdeField("BAPH10", "BAPH10", JdeDataType.String, 6),
        new JdeField("BAUSER", "BAUSER", JdeDataType.String, 20),
        new JdeField("BAPID", "BAPID", JdeDataType.String, 20),
        new JdeField("BAUPMJ", "BAUPMJ", JdeDataType.Numeric),
        new JdeField("BAJOBN", "BAJOBN", JdeDataType.String, 20),
        new JdeField("BAXET1", "BAXET1", JdeDataType.String, 8),
        new JdeField("BAXET2", "BAXET2", JdeDataType.String, 8),
        new JdeField("BAEAOR", "BAEAOR", JdeDataType.String, 2),
        new JdeField("BAARFL", "BAARFL", JdeDataType.String, 2),
        new JdeField("BAPPLN", "BAPPLN", JdeDataType.String, 16),
        new JdeField("BAMXPR", "BAMXPR", JdeDataType.Numeric),
        new JdeField("BARNDA", "BARNDA", JdeDataType.Numeric),
        new JdeField("BACBRA", "BACBRA", JdeDataType.String, 2),
        new JdeField("BAPLN2", "BAPLN2", JdeDataType.String, 16),
        new JdeField("BAFSAF", "BAFSAF", JdeDataType.String, 2),
        new JdeField("BAPAYF", "BAPAYF", JdeDataType.Numeric),
        new JdeField("BAFLXA", "BAFLXA", JdeDataType.String, 2),
        new JdeField("BAPLTZ", "BAPLTZ", JdeDataType.String, 4),
        new JdeField("BAEFL1", "BAEFL1", JdeDataType.String, 2),
        new JdeField("BAEFL2", "BAEFL2", JdeDataType.String, 2),
        new JdeField("BAEFL3", "BAEFL3", JdeDataType.String, 2),
        new JdeField("BAEFL4", "BAEFL4", JdeDataType.String, 2),
        new JdeField("BAEFP1", "BAEFP1", JdeDataType.String, 2),
        new JdeField("BAEFP2", "BAEFP2", JdeDataType.String, 2),
        new JdeField("BAEFP3", "BAEFP3", JdeDataType.String, 2),
        new JdeField("BAEFP4", "BAEFP4", JdeDataType.String, 2),
        new JdeField("BAEFR1", "BAEFR1", JdeDataType.String, 2),
        new JdeField("BAEFR2", "BAEFR2", JdeDataType.String, 2),
        new JdeField("BAEFR3", "BAEFR3", JdeDataType.String, 2),
        new JdeField("BAEFR4", "BAEFR4", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08320_0", "Primary Key on BAPLAN", new[] { "BAPLAN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08320_2", "Index on BADC", new[] { "BADC" })
    };
}
