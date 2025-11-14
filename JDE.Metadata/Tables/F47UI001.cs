using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47UI001 - .
/// </summary>
public class F47UI001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZCTID.
        /// </summary>
        public const string SZCTID = "SZCTID";

        /// <summary>
        /// SZJOBS.
        /// </summary>
        public const string SZJOBS = "SZJOBS";

        /// <summary>
        /// SZHLCF.
        /// </summary>
        public const string SZHLCF = "SZHLCF";

        /// <summary>
        /// SZHLSC.
        /// </summary>
        public const string SZHLSC = "SZHLSC";

        /// <summary>
        /// SZITM.
        /// </summary>
        public const string SZITM = "SZITM";

        /// <summary>
        /// SZSHPN.
        /// </summary>
        public const string SZSHPN = "SZSHPN";

        /// <summary>
        /// SZVC30A.
        /// </summary>
        public const string SZVC30A = "SZVC30A";

        /// <summary>
        /// SZVC30A1.
        /// </summary>
        public const string SZVC30A1 = "SZVC30A1";

        /// <summary>
        /// SZVC30A2.
        /// </summary>
        public const string SZVC30A2 = "SZVC30A2";

        /// <summary>
        /// SZVC30A3.
        /// </summary>
        public const string SZVC30A3 = "SZVC30A3";

        /// <summary>
        /// SZVC30A4.
        /// </summary>
        public const string SZVC30A4 = "SZVC30A4";

        /// <summary>
        /// SZVC30A5.
        /// </summary>
        public const string SZVC30A5 = "SZVC30A5";

        /// <summary>
        /// SZVC30A6.
        /// </summary>
        public const string SZVC30A6 = "SZVC30A6";

        /// <summary>
        /// SZVC30A7.
        /// </summary>
        public const string SZVC30A7 = "SZVC30A7";

        /// <summary>
        /// SZVC30A8.
        /// </summary>
        public const string SZVC30A8 = "SZVC30A8";

        /// <summary>
        /// SZSAD.
        /// </summary>
        public const string SZSAD = "SZSAD";

        /// <summary>
        /// SZSAD1.
        /// </summary>
        public const string SZSAD1 = "SZSAD1";

        /// <summary>
        /// SZSAD2.
        /// </summary>
        public const string SZSAD2 = "SZSAD2";

        /// <summary>
        /// SZSAD3.
        /// </summary>
        public const string SZSAD3 = "SZSAD3";

        /// <summary>
        /// SZSAD4.
        /// </summary>
        public const string SZSAD4 = "SZSAD4";

        /// <summary>
        /// SZSAD5.
        /// </summary>
        public const string SZSAD5 = "SZSAD5";

        /// <summary>
        /// SZSAD6.
        /// </summary>
        public const string SZSAD6 = "SZSAD6";

        /// <summary>
        /// SZSAD7.
        /// </summary>
        public const string SZSAD7 = "SZSAD7";

        /// <summary>
        /// SZSAD8.
        /// </summary>
        public const string SZSAD8 = "SZSAD8";

        /// <summary>
        /// SZDOCO.
        /// </summary>
        public const string SZDOCO = "SZDOCO";

        /// <summary>
        /// SZDCTO.
        /// </summary>
        public const string SZDCTO = "SZDCTO";

        /// <summary>
        /// SZKCOO.
        /// </summary>
        public const string SZKCOO = "SZKCOO";

        /// <summary>
        /// SZLNID.
        /// </summary>
        public const string SZLNID = "SZLNID";

        /// <summary>
        /// SZPLT.
        /// </summary>
        public const string SZPLT = "SZPLT";

        /// <summary>
        /// SZPAK.
        /// </summary>
        public const string SZPAK = "SZPAK";

        /// <summary>
        /// SZSCCN.
        /// </summary>
        public const string SZSCCN = "SZSCCN";

        /// <summary>
        /// SZUPCN.
        /// </summary>
        public const string SZUPCN = "SZUPCN";

        /// <summary>
        /// SZEDDL.
        /// </summary>
        public const string SZEDDL = "SZEDDL";

        /// <summary>
        /// SZGRWT.
        /// </summary>
        public const string SZGRWT = "SZGRWT";

        /// <summary>
        /// SZSOQS.
        /// </summary>
        public const string SZSOQS = "SZSOQS";

        /// <summary>
        /// SZUOM.
        /// </summary>
        public const string SZUOM = "SZUOM";

        /// <summary>
        /// SZAEXP.
        /// </summary>
        public const string SZAEXP = "SZAEXP";

        /// <summary>
        /// SZECST.
        /// </summary>
        public const string SZECST = "SZECST";

        /// <summary>
        /// SZFEA.
        /// </summary>
        public const string SZFEA = "SZFEA";

        /// <summary>
        /// SZFEC.
        /// </summary>
        public const string SZFEC = "SZFEC";

        /// <summary>
        /// SZURAT.
        /// </summary>
        public const string SZURAT = "SZURAT";

        /// <summary>
        /// SZTCST.
        /// </summary>
        public const string SZTCST = "SZTCST";

        /// <summary>
        /// SZPQOR.
        /// </summary>
        public const string SZPQOR = "SZPQOR";

        /// <summary>
        /// SZSQOR.
        /// </summary>
        public const string SZSQOR = "SZSQOR";

        /// <summary>
        /// SZITWT.
        /// </summary>
        public const string SZITWT = "SZITWT";

        /// <summary>
        /// SZITVL.
        /// </summary>
        public const string SZITVL = "SZITVL";

        /// <summary>
        /// SZUORG.
        /// </summary>
        public const string SZUORG = "SZUORG";

        /// <summary>
        /// SZSOBK.
        /// </summary>
        public const string SZSOBK = "SZSOBK";

        /// <summary>
        /// SZSOCN.
        /// </summary>
        public const string SZSOCN = "SZSOCN";

        /// <summary>
        /// SZSONE.
        /// </summary>
        public const string SZSONE = "SZSONE";

        /// <summary>
        /// SZUOPN.
        /// </summary>
        public const string SZUOPN = "SZUOPN";

        /// <summary>
        /// SZQTYT.
        /// </summary>
        public const string SZQTYT = "SZQTYT";

        /// <summary>
        /// SZQRLV.
        /// </summary>
        public const string SZQRLV = "SZQRLV";

        /// <summary>
        /// SZUPQT.
        /// </summary>
        public const string SZUPQT = "SZUPQT";

        /// <summary>
        /// SZUPUM.
        /// </summary>
        public const string SZUPUM = "SZUPUM";

        /// <summary>
        /// SZSCCQ.
        /// </summary>
        public const string SZSCCQ = "SZSCCQ";

        /// <summary>
        /// SZSCUM.
        /// </summary>
        public const string SZSCUM = "SZSCUM";

        /// <summary>
        /// SZUTP.
        /// </summary>
        public const string SZUTP = "SZUTP";

        /// <summary>
        /// SZTAEXP.
        /// </summary>
        public const string SZTAEXP = "SZTAEXP";

        /// <summary>
        /// SZTFEA.
        /// </summary>
        public const string SZTFEA = "SZTFEA";
    }

    /// <inheritdoc />
    public override string TableName => "F47UI001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZCTID", "SZCTID", JdeDataType.String, 30, true, true),
        new JdeField("SZJOBS", "SZJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("SZHLCF", "SZHLCF", JdeDataType.String, 36, true, true),
        new JdeField("SZHLSC", "SZHLSC", JdeDataType.String, 8),
        new JdeField("SZITM", "SZITM", JdeDataType.Numeric),
        new JdeField("SZSHPN", "SZSHPN", JdeDataType.Numeric),
        new JdeField("SZVC30A", "SZVC30A", JdeDataType.String, 60, true, true),
        new JdeField("SZVC30A1", "SZVC30A1", JdeDataType.String, 60, true, true),
        new JdeField("SZVC30A2", "SZVC30A2", JdeDataType.String, 60, true, true),
        new JdeField("SZVC30A3", "SZVC30A3", JdeDataType.String, 60, true, true),
        new JdeField("SZVC30A4", "SZVC30A4", JdeDataType.String, 60, true, true),
        new JdeField("SZVC30A5", "SZVC30A5", JdeDataType.String, 60, true, true),
        new JdeField("SZVC30A6", "SZVC30A6", JdeDataType.String, 60, true, true),
        new JdeField("SZVC30A7", "SZVC30A7", JdeDataType.String, 60, true, true),
        new JdeField("SZVC30A8", "SZVC30A8", JdeDataType.String, 60, true, true),
        new JdeField("SZSAD", "SZSAD", JdeDataType.String, 2),
        new JdeField("SZSAD1", "SZSAD1", JdeDataType.String, 2),
        new JdeField("SZSAD2", "SZSAD2", JdeDataType.String, 2),
        new JdeField("SZSAD3", "SZSAD3", JdeDataType.String, 2),
        new JdeField("SZSAD4", "SZSAD4", JdeDataType.String, 2),
        new JdeField("SZSAD5", "SZSAD5", JdeDataType.String, 2),
        new JdeField("SZSAD6", "SZSAD6", JdeDataType.String, 2),
        new JdeField("SZSAD7", "SZSAD7", JdeDataType.String, 2),
        new JdeField("SZSAD8", "SZSAD8", JdeDataType.String, 2),
        new JdeField("SZDOCO", "SZDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SZDCTO", "SZDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SZKCOO", "SZKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SZLNID", "SZLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SZPLT", "SZPLT", JdeDataType.String, 36),
        new JdeField("SZPAK", "SZPAK", JdeDataType.String, 36),
        new JdeField("SZSCCN", "SZSCCN", JdeDataType.String, 28),
        new JdeField("SZUPCN", "SZUPCN", JdeDataType.String, 26),
        new JdeField("SZEDDL", "SZEDDL", JdeDataType.Numeric),
        new JdeField("SZGRWT", "SZGRWT", JdeDataType.Numeric),
        new JdeField("SZSOQS", "SZSOQS", JdeDataType.Numeric),
        new JdeField("SZUOM", "SZUOM", JdeDataType.String, 4),
        new JdeField("SZAEXP", "SZAEXP", JdeDataType.Numeric),
        new JdeField("SZECST", "SZECST", JdeDataType.Numeric),
        new JdeField("SZFEA", "SZFEA", JdeDataType.Numeric),
        new JdeField("SZFEC", "SZFEC", JdeDataType.Numeric),
        new JdeField("SZURAT", "SZURAT", JdeDataType.Numeric),
        new JdeField("SZTCST", "SZTCST", JdeDataType.Numeric),
        new JdeField("SZPQOR", "SZPQOR", JdeDataType.Numeric),
        new JdeField("SZSQOR", "SZSQOR", JdeDataType.Numeric),
        new JdeField("SZITWT", "SZITWT", JdeDataType.Numeric),
        new JdeField("SZITVL", "SZITVL", JdeDataType.Numeric),
        new JdeField("SZUORG", "SZUORG", JdeDataType.Numeric),
        new JdeField("SZSOBK", "SZSOBK", JdeDataType.Numeric),
        new JdeField("SZSOCN", "SZSOCN", JdeDataType.Numeric),
        new JdeField("SZSONE", "SZSONE", JdeDataType.Numeric),
        new JdeField("SZUOPN", "SZUOPN", JdeDataType.Numeric),
        new JdeField("SZQTYT", "SZQTYT", JdeDataType.Numeric),
        new JdeField("SZQRLV", "SZQRLV", JdeDataType.Numeric),
        new JdeField("SZUPQT", "SZUPQT", JdeDataType.Numeric),
        new JdeField("SZUPUM", "SZUPUM", JdeDataType.String, 4),
        new JdeField("SZSCCQ", "SZSCCQ", JdeDataType.Numeric),
        new JdeField("SZSCUM", "SZSCUM", JdeDataType.String, 4),
        new JdeField("SZUTP", "SZUTP", JdeDataType.String, 2),
        new JdeField("SZTAEXP", "SZTAEXP", JdeDataType.Numeric),
        new JdeField("SZTFEA", "SZTFEA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47UI001_0", "Primary Key on SZCTID, SZJOBS, SZHLCF, SZVC30A, SZVC30A1, SZVC30A2, SZVC30A3, SZVC30A4, SZVC30A5, SZVC30A6, SZVC30A7, SZVC30A8, SZDOCO, SZDCTO, SZKCOO, SZLNID", new[] { "SZCTID", "SZJOBS", "SZHLCF", "SZVC30A", "SZVC30A1", "SZVC30A2", "SZVC30A3", "SZVC30A4", "SZVC30A5", "SZVC30A6", "SZVC30A7", "SZVC30A8", "SZDOCO", "SZDCTO", "SZKCOO", "SZLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
