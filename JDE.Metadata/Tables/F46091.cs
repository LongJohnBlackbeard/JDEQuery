using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46091 - .
/// </summary>
public class F46091 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IDMCU.
        /// </summary>
        public const string IDMCU = "IDMCU";

        /// <summary>
        /// IDEQTY.
        /// </summary>
        public const string IDEQTY = "IDEQTY";

        /// <summary>
        /// IDGWID.
        /// </summary>
        public const string IDGWID = "IDGWID";

        /// <summary>
        /// IDGDEP.
        /// </summary>
        public const string IDGDEP = "IDGDEP";

        /// <summary>
        /// IDGHET.
        /// </summary>
        public const string IDGHET = "IDGHET";

        /// <summary>
        /// IDWIUM.
        /// </summary>
        public const string IDWIUM = "IDWIUM";

        /// <summary>
        /// IDGCUB.
        /// </summary>
        public const string IDGCUB = "IDGCUB";

        /// <summary>
        /// IDVUMD.
        /// </summary>
        public const string IDVUMD = "IDVUMD";

        /// <summary>
        /// IDGWEI.
        /// </summary>
        public const string IDGWEI = "IDGWEI";

        /// <summary>
        /// IDUWUM.
        /// </summary>
        public const string IDUWUM = "IDUWUM";

        /// <summary>
        /// IDSHCT.
        /// </summary>
        public const string IDSHCT = "IDSHCT";

        /// <summary>
        /// IDAVCT.
        /// </summary>
        public const string IDAVCT = "IDAVCT";

        /// <summary>
        /// IDPRSH.
        /// </summary>
        public const string IDPRSH = "IDPRSH";

        /// <summary>
        /// IDCTPR.
        /// </summary>
        public const string IDCTPR = "IDCTPR";

        /// <summary>
        /// IDCTPM.
        /// </summary>
        public const string IDCTPM = "IDCTPM";

        /// <summary>
        /// IDMAXW.
        /// </summary>
        public const string IDMAXW = "IDMAXW";

        /// <summary>
        /// IDUSER.
        /// </summary>
        public const string IDUSER = "IDUSER";

        /// <summary>
        /// IDUPMJ.
        /// </summary>
        public const string IDUPMJ = "IDUPMJ";

        /// <summary>
        /// IDTDAY.
        /// </summary>
        public const string IDTDAY = "IDTDAY";

        /// <summary>
        /// IDGRTH.
        /// </summary>
        public const string IDGRTH = "IDGRTH";

        /// <summary>
        /// IDUCCU.
        /// </summary>
        public const string IDUCCU = "IDUCCU";

        /// <summary>
        /// IDUIUD.
        /// </summary>
        public const string IDUIUD = "IDUIUD";

        /// <summary>
        /// IDITM.
        /// </summary>
        public const string IDITM = "IDITM";

        /// <summary>
        /// IDCNPFG.
        /// </summary>
        public const string IDCNPFG = "IDCNPFG";

        /// <summary>
        /// IDEXCN.
        /// </summary>
        public const string IDEXCN = "IDEXCN";

        /// <summary>
        /// IDPKCD.
        /// </summary>
        public const string IDPKCD = "IDPKCD";

        /// <summary>
        /// IDCSOC.
        /// </summary>
        public const string IDCSOC = "IDCSOC";

        /// <summary>
        /// IDPKGRC.
        /// </summary>
        public const string IDPKGRC = "IDPKGRC";

        /// <summary>
        /// IDPKGTR.
        /// </summary>
        public const string IDPKGTR = "IDPKGTR";

        /// <summary>
        /// IDCTUOM.
        /// </summary>
        public const string IDCTUOM = "IDCTUOM";

        /// <summary>
        /// IDCPRGP1.
        /// </summary>
        public const string IDCPRGP1 = "IDCPRGP1";

        /// <summary>
        /// IDCPRGP2.
        /// </summary>
        public const string IDCPRGP2 = "IDCPRGP2";

        /// <summary>
        /// IDCPRGP3.
        /// </summary>
        public const string IDCPRGP3 = "IDCPRGP3";
    }

    /// <inheritdoc />
    public override string TableName => "F46091";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IDMCU", "IDMCU", JdeDataType.String, 24, true, true),
        new JdeField("IDEQTY", "IDEQTY", JdeDataType.String, 10, true, true),
        new JdeField("IDGWID", "IDGWID", JdeDataType.Numeric),
        new JdeField("IDGDEP", "IDGDEP", JdeDataType.Numeric),
        new JdeField("IDGHET", "IDGHET", JdeDataType.Numeric),
        new JdeField("IDWIUM", "IDWIUM", JdeDataType.String, 4),
        new JdeField("IDGCUB", "IDGCUB", JdeDataType.Numeric),
        new JdeField("IDVUMD", "IDVUMD", JdeDataType.String, 4),
        new JdeField("IDGWEI", "IDGWEI", JdeDataType.Numeric),
        new JdeField("IDUWUM", "IDUWUM", JdeDataType.String, 4),
        new JdeField("IDSHCT", "IDSHCT", JdeDataType.String, 2),
        new JdeField("IDAVCT", "IDAVCT", JdeDataType.String, 2),
        new JdeField("IDPRSH", "IDPRSH", JdeDataType.Numeric),
        new JdeField("IDCTPR", "IDCTPR", JdeDataType.Numeric),
        new JdeField("IDCTPM", "IDCTPM", JdeDataType.Numeric),
        new JdeField("IDMAXW", "IDMAXW", JdeDataType.Numeric),
        new JdeField("IDUSER", "IDUSER", JdeDataType.String, 20),
        new JdeField("IDUPMJ", "IDUPMJ", JdeDataType.Numeric),
        new JdeField("IDTDAY", "IDTDAY", JdeDataType.Numeric),
        new JdeField("IDGRTH", "IDGRTH", JdeDataType.Numeric),
        new JdeField("IDUCCU", "IDUCCU", JdeDataType.String, 2),
        new JdeField("IDUIUD", "IDUIUD", JdeDataType.String, 2),
        new JdeField("IDITM", "IDITM", JdeDataType.Numeric),
        new JdeField("IDCNPFG", "IDCNPFG", JdeDataType.String, 2),
        new JdeField("IDEXCN", "IDEXCN", JdeDataType.String, 2),
        new JdeField("IDPKCD", "IDPKCD", JdeDataType.String, 10),
        new JdeField("IDCSOC", "IDCSOC", JdeDataType.String, 2),
        new JdeField("IDPKGRC", "IDPKGRC", JdeDataType.String, 6),
        new JdeField("IDPKGTR", "IDPKGTR", JdeDataType.String, 6),
        new JdeField("IDCTUOM", "IDCTUOM", JdeDataType.String, 4),
        new JdeField("IDCPRGP1", "IDCPRGP1", JdeDataType.String, 12),
        new JdeField("IDCPRGP2", "IDCPRGP2", JdeDataType.String, 12),
        new JdeField("IDCPRGP3", "IDCPRGP3", JdeDataType.String, 12)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46091_0", "Primary Key on IDMCU, IDEQTY", new[] { "IDMCU", "IDEQTY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46091_2", "Index on IDMCU, IDSHCT, IDAVCT, IDPRSH", new[] { "IDMCU", "IDSHCT", "IDAVCT", "IDPRSH" })
    };
}
