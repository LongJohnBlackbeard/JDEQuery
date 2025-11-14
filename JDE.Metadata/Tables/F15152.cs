using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15152 - .
/// </summary>
public class F15152 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCDOCO.
        /// </summary>
        public const string LCDOCO = "LCDOCO";

        /// <summary>
        /// LCLSVR.
        /// </summary>
        public const string LCLSVR = "LCLSVR";

        /// <summary>
        /// LCBCI.
        /// </summary>
        public const string LCBCI = "LCBCI";

        /// <summary>
        /// LCSEQN.
        /// </summary>
        public const string LCSEQN = "LCSEQN";

        /// <summary>
        /// LCCAPOVTY.
        /// </summary>
        public const string LCCAPOVTY = "LCCAPOVTY";

        /// <summary>
        /// LCCAPID.
        /// </summary>
        public const string LCCAPID = "LCCAPID";

        /// <summary>
        /// LCCAPEFF.
        /// </summary>
        public const string LCCAPEFF = "LCCAPEFF";

        /// <summary>
        /// LCCAPEND.
        /// </summary>
        public const string LCCAPEND = "LCCAPEND";

        /// <summary>
        /// LCCAPBASA.
        /// </summary>
        public const string LCCAPBASA = "LCCAPBASA";

        /// <summary>
        /// LCCAPBASY.
        /// </summary>
        public const string LCCAPBASY = "LCCAPBASY";

        /// <summary>
        /// LCCAPFLOR.
        /// </summary>
        public const string LCCAPFLOR = "LCCAPFLOR";

        /// <summary>
        /// LCCAPCEIL.
        /// </summary>
        public const string LCCAPCEIL = "LCCAPCEIL";

        /// <summary>
        /// LCCAPFIXED.
        /// </summary>
        public const string LCCAPFIXED = "LCCAPFIXED";

        /// <summary>
        /// LCAMTYP.
        /// </summary>
        public const string LCAMTYP = "LCAMTYP";

        /// <summary>
        /// LCCAPAREA.
        /// </summary>
        public const string LCCAPAREA = "LCCAPAREA";

        /// <summary>
        /// LCAPLYCAP.
        /// </summary>
        public const string LCAPLYCAP = "LCAPLYCAP";

        /// <summary>
        /// LCCAPFREQ.
        /// </summary>
        public const string LCCAPFREQ = "LCCAPFREQ";

        /// <summary>
        /// LCCAPPCBAS.
        /// </summary>
        public const string LCCAPPCBAS = "LCCAPPCBAS";

        /// <summary>
        /// LCCAPINCR.
        /// </summary>
        public const string LCCAPINCR = "LCCAPINCR";

        /// <summary>
        /// LCCRCD.
        /// </summary>
        public const string LCCRCD = "LCCRCD";

        /// <summary>
        /// LCRMK.
        /// </summary>
        public const string LCRMK = "LCRMK";

        /// <summary>
        /// LCEPCL.
        /// </summary>
        public const string LCEPCL = "LCEPCL";

        /// <summary>
        /// LCCAPPCT.
        /// </summary>
        public const string LCCAPPCT = "LCCAPPCT";

        /// <summary>
        /// LCCAPIDX.
        /// </summary>
        public const string LCCAPIDX = "LCCAPIDX";

        /// <summary>
        /// LCCIDXMT.
        /// </summary>
        public const string LCCIDXMT = "LCCIDXMT";

        /// <summary>
        /// LCCIDXYR.
        /// </summary>
        public const string LCCIDXYR = "LCCIDXYR";

        /// <summary>
        /// LCURCD.
        /// </summary>
        public const string LCURCD = "LCURCD";

        /// <summary>
        /// LCURDT.
        /// </summary>
        public const string LCURDT = "LCURDT";

        /// <summary>
        /// LCURAT.
        /// </summary>
        public const string LCURAT = "LCURAT";

        /// <summary>
        /// LCURAB.
        /// </summary>
        public const string LCURAB = "LCURAB";

        /// <summary>
        /// LCURRF.
        /// </summary>
        public const string LCURRF = "LCURRF";

        /// <summary>
        /// LCUSER.
        /// </summary>
        public const string LCUSER = "LCUSER";

        /// <summary>
        /// LCPID.
        /// </summary>
        public const string LCPID = "LCPID";

        /// <summary>
        /// LCMKEY.
        /// </summary>
        public const string LCMKEY = "LCMKEY";

        /// <summary>
        /// LCUPMJ.
        /// </summary>
        public const string LCUPMJ = "LCUPMJ";

        /// <summary>
        /// LCUPMT.
        /// </summary>
        public const string LCUPMT = "LCUPMT";

        /// <summary>
        /// LCTORG.
        /// </summary>
        public const string LCTORG = "LCTORG";

        /// <summary>
        /// LCENTJ.
        /// </summary>
        public const string LCENTJ = "LCENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F15152";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCDOCO", "LCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("LCLSVR", "LCLSVR", JdeDataType.Numeric, null, true, true),
        new JdeField("LCBCI", "LCBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("LCSEQN", "LCSEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("LCCAPOVTY", "LCCAPOVTY", JdeDataType.String, 2),
        new JdeField("LCCAPID", "LCCAPID", JdeDataType.String, 20),
        new JdeField("LCCAPEFF", "LCCAPEFF", JdeDataType.Numeric),
        new JdeField("LCCAPEND", "LCCAPEND", JdeDataType.Numeric),
        new JdeField("LCCAPBASA", "LCCAPBASA", JdeDataType.Numeric),
        new JdeField("LCCAPBASY", "LCCAPBASY", JdeDataType.Numeric),
        new JdeField("LCCAPFLOR", "LCCAPFLOR", JdeDataType.Numeric),
        new JdeField("LCCAPCEIL", "LCCAPCEIL", JdeDataType.Numeric),
        new JdeField("LCCAPFIXED", "LCCAPFIXED", JdeDataType.Numeric),
        new JdeField("LCAMTYP", "LCAMTYP", JdeDataType.String, 2),
        new JdeField("LCCAPAREA", "LCCAPAREA", JdeDataType.Numeric),
        new JdeField("LCAPLYCAP", "LCAPLYCAP", JdeDataType.String, 2),
        new JdeField("LCCAPFREQ", "LCCAPFREQ", JdeDataType.Numeric),
        new JdeField("LCCAPPCBAS", "LCCAPPCBAS", JdeDataType.Numeric),
        new JdeField("LCCAPINCR", "LCCAPINCR", JdeDataType.String, 2),
        new JdeField("LCCRCD", "LCCRCD", JdeDataType.String, 6),
        new JdeField("LCRMK", "LCRMK", JdeDataType.String, 60),
        new JdeField("LCEPCL", "LCEPCL", JdeDataType.String, 8),
        new JdeField("LCCAPPCT", "LCCAPPCT", JdeDataType.Numeric),
        new JdeField("LCCAPIDX", "LCCAPIDX", JdeDataType.String, 10),
        new JdeField("LCCIDXMT", "LCCIDXMT", JdeDataType.Numeric),
        new JdeField("LCCIDXYR", "LCCIDXYR", JdeDataType.Numeric),
        new JdeField("LCURCD", "LCURCD", JdeDataType.String, 4),
        new JdeField("LCURDT", "LCURDT", JdeDataType.Numeric),
        new JdeField("LCURAT", "LCURAT", JdeDataType.Numeric),
        new JdeField("LCURAB", "LCURAB", JdeDataType.Numeric),
        new JdeField("LCURRF", "LCURRF", JdeDataType.String, 30),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCMKEY", "LCMKEY", JdeDataType.String, 30),
        new JdeField("LCUPMJ", "LCUPMJ", JdeDataType.Numeric),
        new JdeField("LCUPMT", "LCUPMT", JdeDataType.Numeric),
        new JdeField("LCTORG", "LCTORG", JdeDataType.String, 20),
        new JdeField("LCENTJ", "LCENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15152_0", "Primary Key on LCDOCO, LCLSVR, LCBCI, LCSEQN", new[] { "LCDOCO", "LCLSVR", "LCBCI", "LCSEQN" }, isUnique: true, isPrimaryKey: true)
    };
}
