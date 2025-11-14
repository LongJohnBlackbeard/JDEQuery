using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3291 - .
/// </summary>
public class F3291 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KWKIT.
        /// </summary>
        public const string KWKIT = "KWKIT";

        /// <summary>
        /// KWLITM.
        /// </summary>
        public const string KWLITM = "KWLITM";

        /// <summary>
        /// KWAITM.
        /// </summary>
        public const string KWAITM = "KWAITM";

        /// <summary>
        /// KWMCU.
        /// </summary>
        public const string KWMCU = "KWMCU";

        /// <summary>
        /// KWPEL.
        /// </summary>
        public const string KWPEL = "KWPEL";

        /// <summary>
        /// KWEFFF.
        /// </summary>
        public const string KWEFFF = "KWEFFF";

        /// <summary>
        /// KWEFFT.
        /// </summary>
        public const string KWEFFT = "KWEFFT";

        /// <summary>
        /// KWDSC1.
        /// </summary>
        public const string KWDSC1 = "KWDSC1";

        /// <summary>
        /// KWDTAI.
        /// </summary>
        public const string KWDTAI = "KWDTAI";

        /// <summary>
        /// KWATRQ.
        /// </summary>
        public const string KWATRQ = "KWATRQ";

        /// <summary>
        /// KWSY.
        /// </summary>
        public const string KWSY = "KWSY";

        /// <summary>
        /// KWRT.
        /// </summary>
        public const string KWRT = "KWRT";

        /// <summary>
        /// KWDVAL.
        /// </summary>
        public const string KWDVAL = "KWDVAL";

        /// <summary>
        /// KWLVAL.
        /// </summary>
        public const string KWLVAL = "KWLVAL";

        /// <summary>
        /// KWUVAL.
        /// </summary>
        public const string KWUVAL = "KWUVAL";

        /// <summary>
        /// KWCNUM.
        /// </summary>
        public const string KWCNUM = "KWCNUM";

        /// <summary>
        /// KWDTAS.
        /// </summary>
        public const string KWDTAS = "KWDTAS";

        /// <summary>
        /// KWCDEC.
        /// </summary>
        public const string KWCDEC = "KWCDEC";

        /// <summary>
        /// KWATSA.
        /// </summary>
        public const string KWATSA = "KWATSA";

        /// <summary>
        /// KWSPBN.
        /// </summary>
        public const string KWSPBN = "KWSPBN";

        /// <summary>
        /// KWATSN.
        /// </summary>
        public const string KWATSN = "KWATSN";

        /// <summary>
        /// KWATSD.
        /// </summary>
        public const string KWATSD = "KWATSD";

        /// <summary>
        /// KWATSV.
        /// </summary>
        public const string KWATSV = "KWATSV";

        /// <summary>
        /// KWATVD.
        /// </summary>
        public const string KWATVD = "KWATVD";

        /// <summary>
        /// KWSPAN.
        /// </summary>
        public const string KWSPAN = "KWSPAN";

        /// <summary>
        /// KWRTNL.
        /// </summary>
        public const string KWRTNL = "KWRTNL";

        /// <summary>
        /// KWRNDC.
        /// </summary>
        public const string KWRNDC = "KWRNDC";

        /// <summary>
        /// KWUPCC.
        /// </summary>
        public const string KWUPCC = "KWUPCC";

        /// <summary>
        /// KWURCD.
        /// </summary>
        public const string KWURCD = "KWURCD";

        /// <summary>
        /// KWURDT.
        /// </summary>
        public const string KWURDT = "KWURDT";

        /// <summary>
        /// KWURAT.
        /// </summary>
        public const string KWURAT = "KWURAT";

        /// <summary>
        /// KWURAB.
        /// </summary>
        public const string KWURAB = "KWURAB";

        /// <summary>
        /// KWURRF.
        /// </summary>
        public const string KWURRF = "KWURRF";

        /// <summary>
        /// KWUSER.
        /// </summary>
        public const string KWUSER = "KWUSER";

        /// <summary>
        /// KWPID.
        /// </summary>
        public const string KWPID = "KWPID";

        /// <summary>
        /// KWJOBN.
        /// </summary>
        public const string KWJOBN = "KWJOBN";

        /// <summary>
        /// KWUPMJ.
        /// </summary>
        public const string KWUPMJ = "KWUPMJ";

        /// <summary>
        /// KWTDAY.
        /// </summary>
        public const string KWTDAY = "KWTDAY";

        /// <summary>
        /// KWDSPCALC.
        /// </summary>
        public const string KWDSPCALC = "KWDSPCALC";
    }

    /// <inheritdoc />
    public override string TableName => "F3291";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KWKIT", "KWKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("KWLITM", "KWLITM", JdeDataType.String, 50),
        new JdeField("KWAITM", "KWAITM", JdeDataType.String, 50),
        new JdeField("KWMCU", "KWMCU", JdeDataType.String, 24, true, true),
        new JdeField("KWPEL", "KWPEL", JdeDataType.Numeric, null, true, true),
        new JdeField("KWEFFF", "KWEFFF", JdeDataType.Numeric),
        new JdeField("KWEFFT", "KWEFFT", JdeDataType.Numeric),
        new JdeField("KWDSC1", "KWDSC1", JdeDataType.String, 60),
        new JdeField("KWDTAI", "KWDTAI", JdeDataType.String, 20),
        new JdeField("KWATRQ", "KWATRQ", JdeDataType.String, 2),
        new JdeField("KWSY", "KWSY", JdeDataType.String, 8),
        new JdeField("KWRT", "KWRT", JdeDataType.String, 4),
        new JdeField("KWDVAL", "KWDVAL", JdeDataType.String, 80),
        new JdeField("KWLVAL", "KWLVAL", JdeDataType.String, 80),
        new JdeField("KWUVAL", "KWUVAL", JdeDataType.String, 80),
        new JdeField("KWCNUM", "KWCNUM", JdeDataType.String, 2),
        new JdeField("KWDTAS", "KWDTAS", JdeDataType.Numeric),
        new JdeField("KWCDEC", "KWCDEC", JdeDataType.String, 2),
        new JdeField("KWATSA", "KWATSA", JdeDataType.String, 2),
        new JdeField("KWSPBN", "KWSPBN", JdeDataType.Numeric),
        new JdeField("KWATSN", "KWATSN", JdeDataType.String, 2),
        new JdeField("KWATSD", "KWATSD", JdeDataType.String, 2),
        new JdeField("KWATSV", "KWATSV", JdeDataType.String, 2),
        new JdeField("KWATVD", "KWATVD", JdeDataType.String, 2),
        new JdeField("KWSPAN", "KWSPAN", JdeDataType.Numeric),
        new JdeField("KWRTNL", "KWRTNL", JdeDataType.String, 2),
        new JdeField("KWRNDC", "KWRNDC", JdeDataType.String, 2),
        new JdeField("KWUPCC", "KWUPCC", JdeDataType.String, 8),
        new JdeField("KWURCD", "KWURCD", JdeDataType.String, 4),
        new JdeField("KWURDT", "KWURDT", JdeDataType.Numeric),
        new JdeField("KWURAT", "KWURAT", JdeDataType.Numeric),
        new JdeField("KWURAB", "KWURAB", JdeDataType.Numeric),
        new JdeField("KWURRF", "KWURRF", JdeDataType.String, 30),
        new JdeField("KWUSER", "KWUSER", JdeDataType.String, 20),
        new JdeField("KWPID", "KWPID", JdeDataType.String, 20),
        new JdeField("KWJOBN", "KWJOBN", JdeDataType.String, 20),
        new JdeField("KWUPMJ", "KWUPMJ", JdeDataType.Numeric),
        new JdeField("KWTDAY", "KWTDAY", JdeDataType.Numeric),
        new JdeField("KWDSPCALC", "KWDSPCALC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3291_0", "Primary Key on KWKIT, KWMCU, KWPEL", new[] { "KWKIT", "KWMCU", "KWPEL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3291_2", "Index on KWSY, KWRT", new[] { "KWSY", "KWRT" }),
        new JdeIndex("F3291_3", "Index on KWMCU, KWKIT", new[] { "KWMCU", "KWKIT" })
    };
}
