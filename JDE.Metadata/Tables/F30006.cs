using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F30006 - .
/// </summary>
public class F30006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IWMCU.
        /// </summary>
        public const string IWMCU = "IWMCU";

        /// <summary>
        /// IWMCUW.
        /// </summary>
        public const string IWMCUW = "IWMCUW";

        /// <summary>
        /// IWMMCU.
        /// </summary>
        public const string IWMMCU = "IWMMCU";

        /// <summary>
        /// IWLOCN.
        /// </summary>
        public const string IWLOCN = "IWLOCN";

        /// <summary>
        /// IWCRTW.
        /// </summary>
        public const string IWCRTW = "IWCRTW";

        /// <summary>
        /// IWPILC.
        /// </summary>
        public const string IWPILC = "IWPILC";

        /// <summary>
        /// IWBFPF.
        /// </summary>
        public const string IWBFPF = "IWBFPF";

        /// <summary>
        /// IWDEMO.
        /// </summary>
        public const string IWDEMO = "IWDEMO";

        /// <summary>
        /// IWAN8.
        /// </summary>
        public const string IWAN8 = "IWAN8";

        /// <summary>
        /// IWAVRT.
        /// </summary>
        public const string IWAVRT = "IWAVRT";

        /// <summary>
        /// IWTRKS.
        /// </summary>
        public const string IWTRKS = "IWTRKS";

        /// <summary>
        /// IWWRHR.
        /// </summary>
        public const string IWWRHR = "IWWRHR";

        /// <summary>
        /// IWWORE.
        /// </summary>
        public const string IWWORE = "IWWORE";

        /// <summary>
        /// IWWORU.
        /// </summary>
        public const string IWWORU = "IWWORU";

        /// <summary>
        /// IWQMAD.
        /// </summary>
        public const string IWQMAD = "IWQMAD";

        /// <summary>
        /// IWNOMA.
        /// </summary>
        public const string IWNOMA = "IWNOMA";

        /// <summary>
        /// IWSQD.
        /// </summary>
        public const string IWSQD = "IWSQD";

        /// <summary>
        /// IWMOVD.
        /// </summary>
        public const string IWMOVD = "IWMOVD";

        /// <summary>
        /// IWQUED.
        /// </summary>
        public const string IWQUED = "IWQUED";

        /// <summary>
        /// IWSETC.
        /// </summary>
        public const string IWSETC = "IWSETC";

        /// <summary>
        /// IWDL1.
        /// </summary>
        public const string IWDL1 = "IWDL1";

        /// <summary>
        /// IWDL2.
        /// </summary>
        public const string IWDL2 = "IWDL2";

        /// <summary>
        /// IWDL3.
        /// </summary>
        public const string IWDL3 = "IWDL3";

        /// <summary>
        /// IWDE1.
        /// </summary>
        public const string IWDE1 = "IWDE1";

        /// <summary>
        /// IWDE2.
        /// </summary>
        public const string IWDE2 = "IWDE2";

        /// <summary>
        /// IWDE3.
        /// </summary>
        public const string IWDE3 = "IWDE3";

        /// <summary>
        /// IWDC1.
        /// </summary>
        public const string IWDC1 = "IWDC1";

        /// <summary>
        /// IWDC2.
        /// </summary>
        public const string IWDC2 = "IWDC2";

        /// <summary>
        /// IWDC3.
        /// </summary>
        public const string IWDC3 = "IWDC3";

        /// <summary>
        /// IWURDT.
        /// </summary>
        public const string IWURDT = "IWURDT";

        /// <summary>
        /// IWURAT.
        /// </summary>
        public const string IWURAT = "IWURAT";

        /// <summary>
        /// IWURAB.
        /// </summary>
        public const string IWURAB = "IWURAB";

        /// <summary>
        /// IWURRF.
        /// </summary>
        public const string IWURRF = "IWURRF";

        /// <summary>
        /// IWURCD.
        /// </summary>
        public const string IWURCD = "IWURCD";

        /// <summary>
        /// IWUSER.
        /// </summary>
        public const string IWUSER = "IWUSER";

        /// <summary>
        /// IWPID.
        /// </summary>
        public const string IWPID = "IWPID";

        /// <summary>
        /// IWUPMJ.
        /// </summary>
        public const string IWUPMJ = "IWUPMJ";

        /// <summary>
        /// IWTDAY.
        /// </summary>
        public const string IWTDAY = "IWTDAY";

        /// <summary>
        /// IWJOBN.
        /// </summary>
        public const string IWJOBN = "IWJOBN";

        /// <summary>
        /// IWWDCT.
        /// </summary>
        public const string IWWDCT = "IWWDCT";

        /// <summary>
        /// IWWDCK.
        /// </summary>
        public const string IWWDCK = "IWWDCK";

        /// <summary>
        /// IWLOMC.
        /// </summary>
        public const string IWLOMC = "IWLOMC";

        /// <summary>
        /// IWLIC.
        /// </summary>
        public const string IWLIC = "IWLIC";

        /// <summary>
        /// IWWRH2.
        /// </summary>
        public const string IWWRH2 = "IWWRH2";

        /// <summary>
        /// IWWRH3.
        /// </summary>
        public const string IWWRH3 = "IWWRH3";

        /// <summary>
        /// IWWRH4.
        /// </summary>
        public const string IWWRH4 = "IWWRH4";

        /// <summary>
        /// IWWRH5.
        /// </summary>
        public const string IWWRH5 = "IWWRH5";

        /// <summary>
        /// IWWRH6.
        /// </summary>
        public const string IWWRH6 = "IWWRH6";

        /// <summary>
        /// IWCAPU.
        /// </summary>
        public const string IWCAPU = "IWCAPU";

        /// <summary>
        /// IWCPSD.
        /// </summary>
        public const string IWCPSD = "IWCPSD";

        /// <summary>
        /// IWCPMI.
        /// </summary>
        public const string IWCPMI = "IWCPMI";

        /// <summary>
        /// IWCPMA.
        /// </summary>
        public const string IWCPMA = "IWCPMA";

        /// <summary>
        /// IWCOLO.
        /// </summary>
        public const string IWCOLO = "IWCOLO";

        /// <summary>
        /// IWBFWC.
        /// </summary>
        public const string IWBFWC = "IWBFWC";

        /// <summary>
        /// IWITML.
        /// </summary>
        public const string IWITML = "IWITML";

        /// <summary>
        /// IWAPSC.
        /// </summary>
        public const string IWAPSC = "IWAPSC";
    }

    /// <inheritdoc />
    public override string TableName => "F30006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IWMCU", "IWMCU", JdeDataType.String, 24, true, true),
        new JdeField("IWMCUW", "IWMCUW", JdeDataType.String, 24),
        new JdeField("IWMMCU", "IWMMCU", JdeDataType.String, 24, true, true),
        new JdeField("IWLOCN", "IWLOCN", JdeDataType.String, 40),
        new JdeField("IWCRTW", "IWCRTW", JdeDataType.String, 2),
        new JdeField("IWPILC", "IWPILC", JdeDataType.String, 2),
        new JdeField("IWBFPF", "IWBFPF", JdeDataType.String, 2),
        new JdeField("IWDEMO", "IWDEMO", JdeDataType.String, 2),
        new JdeField("IWAN8", "IWAN8", JdeDataType.Numeric),
        new JdeField("IWAVRT", "IWAVRT", JdeDataType.Numeric),
        new JdeField("IWTRKS", "IWTRKS", JdeDataType.Numeric),
        new JdeField("IWWRHR", "IWWRHR", JdeDataType.Numeric),
        new JdeField("IWWORE", "IWWORE", JdeDataType.Numeric),
        new JdeField("IWWORU", "IWWORU", JdeDataType.Numeric),
        new JdeField("IWQMAD", "IWQMAD", JdeDataType.Numeric),
        new JdeField("IWNOMA", "IWNOMA", JdeDataType.Numeric),
        new JdeField("IWSQD", "IWSQD", JdeDataType.Numeric),
        new JdeField("IWMOVD", "IWMOVD", JdeDataType.Numeric),
        new JdeField("IWQUED", "IWQUED", JdeDataType.Numeric),
        new JdeField("IWSETC", "IWSETC", JdeDataType.Numeric),
        new JdeField("IWDL1", "IWDL1", JdeDataType.Numeric),
        new JdeField("IWDL2", "IWDL2", JdeDataType.Numeric),
        new JdeField("IWDL3", "IWDL3", JdeDataType.Numeric),
        new JdeField("IWDE1", "IWDE1", JdeDataType.Numeric),
        new JdeField("IWDE2", "IWDE2", JdeDataType.Numeric),
        new JdeField("IWDE3", "IWDE3", JdeDataType.Numeric),
        new JdeField("IWDC1", "IWDC1", JdeDataType.String, 2),
        new JdeField("IWDC2", "IWDC2", JdeDataType.String, 2),
        new JdeField("IWDC3", "IWDC3", JdeDataType.String, 2),
        new JdeField("IWURDT", "IWURDT", JdeDataType.Numeric),
        new JdeField("IWURAT", "IWURAT", JdeDataType.Numeric),
        new JdeField("IWURAB", "IWURAB", JdeDataType.Numeric),
        new JdeField("IWURRF", "IWURRF", JdeDataType.String, 30),
        new JdeField("IWURCD", "IWURCD", JdeDataType.String, 4),
        new JdeField("IWUSER", "IWUSER", JdeDataType.String, 20),
        new JdeField("IWPID", "IWPID", JdeDataType.String, 20),
        new JdeField("IWUPMJ", "IWUPMJ", JdeDataType.Numeric),
        new JdeField("IWTDAY", "IWTDAY", JdeDataType.Numeric),
        new JdeField("IWJOBN", "IWJOBN", JdeDataType.String, 20),
        new JdeField("IWWDCT", "IWWDCT", JdeDataType.String, 20),
        new JdeField("IWWDCK", "IWWDCK", JdeDataType.String, 20),
        new JdeField("IWLOMC", "IWLOMC", JdeDataType.String, 24),
        new JdeField("IWLIC", "IWLIC", JdeDataType.String, 2),
        new JdeField("IWWRH2", "IWWRH2", JdeDataType.Numeric),
        new JdeField("IWWRH3", "IWWRH3", JdeDataType.Numeric),
        new JdeField("IWWRH4", "IWWRH4", JdeDataType.Numeric),
        new JdeField("IWWRH5", "IWWRH5", JdeDataType.Numeric),
        new JdeField("IWWRH6", "IWWRH6", JdeDataType.Numeric),
        new JdeField("IWCAPU", "IWCAPU", JdeDataType.String, 4),
        new JdeField("IWCPSD", "IWCPSD", JdeDataType.Numeric),
        new JdeField("IWCPMI", "IWCPMI", JdeDataType.Numeric),
        new JdeField("IWCPMA", "IWCPMA", JdeDataType.Numeric),
        new JdeField("IWCOLO", "IWCOLO", JdeDataType.String, 40),
        new JdeField("IWBFWC", "IWBFWC", JdeDataType.String, 2),
        new JdeField("IWITML", "IWITML", JdeDataType.Numeric),
        new JdeField("IWAPSC", "IWAPSC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F30006_0", "Primary Key on IWMMCU, IWMCU", new[] { "IWMMCU", "IWMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F30006_2", "Index on IWMCUW, IWMMCU, IWMCU", new[] { "IWMCUW", "IWMMCU", "IWMCU" })
    };
}
