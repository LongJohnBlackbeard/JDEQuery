using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0413Z1 - .
/// </summary>
public class F0413Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SYEDUS.
        /// </summary>
        public const string SYEDUS = "SYEDUS";

        /// <summary>
        /// SYEDBT.
        /// </summary>
        public const string SYEDBT = "SYEDBT";

        /// <summary>
        /// SYEDTN.
        /// </summary>
        public const string SYEDTN = "SYEDTN";

        /// <summary>
        /// SYEDLN.
        /// </summary>
        public const string SYEDLN = "SYEDLN";

        /// <summary>
        /// SYEDCT.
        /// </summary>
        public const string SYEDCT = "SYEDCT";

        /// <summary>
        /// SYTYTN.
        /// </summary>
        public const string SYTYTN = "SYTYTN";

        /// <summary>
        /// SYEDFT.
        /// </summary>
        public const string SYEDFT = "SYEDFT";

        /// <summary>
        /// SYEDDT.
        /// </summary>
        public const string SYEDDT = "SYEDDT";

        /// <summary>
        /// SYDRIN.
        /// </summary>
        public const string SYDRIN = "SYDRIN";

        /// <summary>
        /// SYEDDL.
        /// </summary>
        public const string SYEDDL = "SYEDDL";

        /// <summary>
        /// SYEDSP.
        /// </summary>
        public const string SYEDSP = "SYEDSP";

        /// <summary>
        /// SYPNID.
        /// </summary>
        public const string SYPNID = "SYPNID";

        /// <summary>
        /// SYTNAC.
        /// </summary>
        public const string SYTNAC = "SYTNAC";

        /// <summary>
        /// SYPYID.
        /// </summary>
        public const string SYPYID = "SYPYID";

        /// <summary>
        /// SYDCTM.
        /// </summary>
        public const string SYDCTM = "SYDCTM";

        /// <summary>
        /// SYDOCM.
        /// </summary>
        public const string SYDOCM = "SYDOCM";

        /// <summary>
        /// SYPYE.
        /// </summary>
        public const string SYPYE = "SYPYE";

        /// <summary>
        /// SYGLBA.
        /// </summary>
        public const string SYGLBA = "SYGLBA";

        /// <summary>
        /// SYCO.
        /// </summary>
        public const string SYCO = "SYCO";

        /// <summary>
        /// SYDMTJ.
        /// </summary>
        public const string SYDMTJ = "SYDMTJ";

        /// <summary>
        /// SYVDGJ.
        /// </summary>
        public const string SYVDGJ = "SYVDGJ";

        /// <summary>
        /// SYICU.
        /// </summary>
        public const string SYICU = "SYICU";

        /// <summary>
        /// SYICUT.
        /// </summary>
        public const string SYICUT = "SYICUT";

        /// <summary>
        /// SYDICJ.
        /// </summary>
        public const string SYDICJ = "SYDICJ";

        /// <summary>
        /// SYPAAP.
        /// </summary>
        public const string SYPAAP = "SYPAAP";

        /// <summary>
        /// SYCRCD.
        /// </summary>
        public const string SYCRCD = "SYCRCD";

        /// <summary>
        /// SYCRRM.
        /// </summary>
        public const string SYCRRM = "SYCRRM";

        /// <summary>
        /// SYCRDC.
        /// </summary>
        public const string SYCRDC = "SYCRDC";

        /// <summary>
        /// SYAM.
        /// </summary>
        public const string SYAM = "SYAM";

        /// <summary>
        /// SYVLDT.
        /// </summary>
        public const string SYVLDT = "SYVLDT";

        /// <summary>
        /// SYPYIN.
        /// </summary>
        public const string SYPYIN = "SYPYIN";

        /// <summary>
        /// SYISTP.
        /// </summary>
        public const string SYISTP = "SYISTP";

        /// <summary>
        /// SYCBNK.
        /// </summary>
        public const string SYCBNK = "SYCBNK";

        /// <summary>
        /// SYBKTR.
        /// </summary>
        public const string SYBKTR = "SYBKTR";

        /// <summary>
        /// SYURCD.
        /// </summary>
        public const string SYURCD = "SYURCD";

        /// <summary>
        /// SYURDT.
        /// </summary>
        public const string SYURDT = "SYURDT";

        /// <summary>
        /// SYURAT.
        /// </summary>
        public const string SYURAT = "SYURAT";

        /// <summary>
        /// SYURAB.
        /// </summary>
        public const string SYURAB = "SYURAB";

        /// <summary>
        /// SYURRF.
        /// </summary>
        public const string SYURRF = "SYURRF";

        /// <summary>
        /// SYTORG.
        /// </summary>
        public const string SYTORG = "SYTORG";

        /// <summary>
        /// SYUSER.
        /// </summary>
        public const string SYUSER = "SYUSER";

        /// <summary>
        /// SYPID.
        /// </summary>
        public const string SYPID = "SYPID";

        /// <summary>
        /// SYJOBN.
        /// </summary>
        public const string SYJOBN = "SYJOBN";

        /// <summary>
        /// SYUPMJ.
        /// </summary>
        public const string SYUPMJ = "SYUPMJ";

        /// <summary>
        /// SYUPMT.
        /// </summary>
        public const string SYUPMT = "SYUPMT";

        /// <summary>
        /// SYTDAY.
        /// </summary>
        public const string SYTDAY = "SYTDAY";

        /// <summary>
        /// SYMIP.
        /// </summary>
        public const string SYMIP = "SYMIP";

        /// <summary>
        /// SYLRFL.
        /// </summary>
        public const string SYLRFL = "SYLRFL";

        /// <summary>
        /// SYPRGF.
        /// </summary>
        public const string SYPRGF = "SYPRGF";

        /// <summary>
        /// SYGFL7.
        /// </summary>
        public const string SYGFL7 = "SYGFL7";

        /// <summary>
        /// SYGFL8.
        /// </summary>
        public const string SYGFL8 = "SYGFL8";

        /// <summary>
        /// SYGAM3.
        /// </summary>
        public const string SYGAM3 = "SYGAM3";

        /// <summary>
        /// SYGAM4.
        /// </summary>
        public const string SYGAM4 = "SYGAM4";

        /// <summary>
        /// SYGEN6.
        /// </summary>
        public const string SYGEN6 = "SYGEN6";

        /// <summary>
        /// SYGEN7.
        /// </summary>
        public const string SYGEN7 = "SYGEN7";

        /// <summary>
        /// SYNETTCID.
        /// </summary>
        public const string SYNETTCID = "SYNETTCID";

        /// <summary>
        /// SYNETDOC.
        /// </summary>
        public const string SYNETDOC = "SYNETDOC";

        /// <summary>
        /// SYRCND.
        /// </summary>
        public const string SYRCND = "SYRCND";

        /// <summary>
        /// SYR3.
        /// </summary>
        public const string SYR3 = "SYR3";

        /// <summary>
        /// SYCNTRTID.
        /// </summary>
        public const string SYCNTRTID = "SYCNTRTID";

        /// <summary>
        /// SYCNTRTCD.
        /// </summary>
        public const string SYCNTRTCD = "SYCNTRTCD";

        /// <summary>
        /// SYWVID.
        /// </summary>
        public const string SYWVID = "SYWVID";

        /// <summary>
        /// SYBLSCD2.
        /// </summary>
        public const string SYBLSCD2 = "SYBLSCD2";

        /// <summary>
        /// SYHARPER.
        /// </summary>
        public const string SYHARPER = "SYHARPER";

        /// <summary>
        /// SYHARSFX.
        /// </summary>
        public const string SYHARSFX = "SYHARSFX";
    }

    /// <inheritdoc />
    public override string TableName => "F0413Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SYEDUS", "SYEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SYEDBT", "SYEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SYEDTN", "SYEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SYEDLN", "SYEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SYEDCT", "SYEDCT", JdeDataType.String, 4),
        new JdeField("SYTYTN", "SYTYTN", JdeDataType.String, 16),
        new JdeField("SYEDFT", "SYEDFT", JdeDataType.String, 20),
        new JdeField("SYEDDT", "SYEDDT", JdeDataType.Numeric),
        new JdeField("SYDRIN", "SYDRIN", JdeDataType.String, 2),
        new JdeField("SYEDDL", "SYEDDL", JdeDataType.Numeric),
        new JdeField("SYEDSP", "SYEDSP", JdeDataType.String, 2),
        new JdeField("SYPNID", "SYPNID", JdeDataType.String, 30),
        new JdeField("SYTNAC", "SYTNAC", JdeDataType.String, 4),
        new JdeField("SYPYID", "SYPYID", JdeDataType.Numeric),
        new JdeField("SYDCTM", "SYDCTM", JdeDataType.String, 4),
        new JdeField("SYDOCM", "SYDOCM", JdeDataType.Numeric),
        new JdeField("SYPYE", "SYPYE", JdeDataType.Numeric),
        new JdeField("SYGLBA", "SYGLBA", JdeDataType.String, 16),
        new JdeField("SYCO", "SYCO", JdeDataType.String, 10),
        new JdeField("SYDMTJ", "SYDMTJ", JdeDataType.Numeric),
        new JdeField("SYVDGJ", "SYVDGJ", JdeDataType.Numeric),
        new JdeField("SYICU", "SYICU", JdeDataType.Numeric),
        new JdeField("SYICUT", "SYICUT", JdeDataType.String, 4),
        new JdeField("SYDICJ", "SYDICJ", JdeDataType.Numeric),
        new JdeField("SYPAAP", "SYPAAP", JdeDataType.Numeric),
        new JdeField("SYCRCD", "SYCRCD", JdeDataType.String, 6),
        new JdeField("SYCRRM", "SYCRRM", JdeDataType.String, 2),
        new JdeField("SYCRDC", "SYCRDC", JdeDataType.String, 6),
        new JdeField("SYAM", "SYAM", JdeDataType.String, 2),
        new JdeField("SYVLDT", "SYVLDT", JdeDataType.Numeric),
        new JdeField("SYPYIN", "SYPYIN", JdeDataType.String, 2),
        new JdeField("SYISTP", "SYISTP", JdeDataType.String, 2),
        new JdeField("SYCBNK", "SYCBNK", JdeDataType.String, 40),
        new JdeField("SYBKTR", "SYBKTR", JdeDataType.String, 16),
        new JdeField("SYURCD", "SYURCD", JdeDataType.String, 4),
        new JdeField("SYURDT", "SYURDT", JdeDataType.Numeric),
        new JdeField("SYURAT", "SYURAT", JdeDataType.Numeric),
        new JdeField("SYURAB", "SYURAB", JdeDataType.Numeric),
        new JdeField("SYURRF", "SYURRF", JdeDataType.String, 30),
        new JdeField("SYTORG", "SYTORG", JdeDataType.String, 20),
        new JdeField("SYUSER", "SYUSER", JdeDataType.String, 20),
        new JdeField("SYPID", "SYPID", JdeDataType.String, 20),
        new JdeField("SYJOBN", "SYJOBN", JdeDataType.String, 20),
        new JdeField("SYUPMJ", "SYUPMJ", JdeDataType.Numeric),
        new JdeField("SYUPMT", "SYUPMT", JdeDataType.Numeric),
        new JdeField("SYTDAY", "SYTDAY", JdeDataType.Numeric),
        new JdeField("SYMIP", "SYMIP", JdeDataType.String, 2),
        new JdeField("SYLRFL", "SYLRFL", JdeDataType.String, 2),
        new JdeField("SYPRGF", "SYPRGF", JdeDataType.String, 2),
        new JdeField("SYGFL7", "SYGFL7", JdeDataType.String, 2),
        new JdeField("SYGFL8", "SYGFL8", JdeDataType.String, 2),
        new JdeField("SYGAM3", "SYGAM3", JdeDataType.Numeric),
        new JdeField("SYGAM4", "SYGAM4", JdeDataType.Numeric),
        new JdeField("SYGEN6", "SYGEN6", JdeDataType.String, 50),
        new JdeField("SYGEN7", "SYGEN7", JdeDataType.String, 50),
        new JdeField("SYNETTCID", "SYNETTCID", JdeDataType.Numeric),
        new JdeField("SYNETDOC", "SYNETDOC", JdeDataType.Numeric),
        new JdeField("SYRCND", "SYRCND", JdeDataType.String, 2),
        new JdeField("SYR3", "SYR3", JdeDataType.String, 16),
        new JdeField("SYCNTRTID", "SYCNTRTID", JdeDataType.Numeric),
        new JdeField("SYCNTRTCD", "SYCNTRTCD", JdeDataType.String, 24),
        new JdeField("SYWVID", "SYWVID", JdeDataType.Numeric),
        new JdeField("SYBLSCD2", "SYBLSCD2", JdeDataType.String, 20),
        new JdeField("SYHARPER", "SYHARPER", JdeDataType.String, 12),
        new JdeField("SYHARSFX", "SYHARSFX", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0413Z1_0", "Primary Key on SYEDUS, SYEDBT, SYEDTN, SYEDLN", new[] { "SYEDUS", "SYEDBT", "SYEDTN", "SYEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0413Z1_2", "Index on SYPYID", new[] { "SYPYID" })
    };
}
