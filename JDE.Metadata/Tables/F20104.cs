using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F20104 - .
/// </summary>
public class F20104 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GPGRPPROF.
        /// </summary>
        public const string GPGRPPROF = "GPGRPPROF";

        /// <summary>
        /// GPDL01.
        /// </summary>
        public const string GPDL01 = "GPDL01";

        /// <summary>
        /// GPPOLICY.
        /// </summary>
        public const string GPPOLICY = "GPPOLICY";

        /// <summary>
        /// GPEXRTID.
        /// </summary>
        public const string GPEXRTID = "GPEXRTID";

        /// <summary>
        /// GPREIMMETH.
        /// </summary>
        public const string GPREIMMETH = "GPREIMMETH";

        /// <summary>
        /// GPREIMCRCY.
        /// </summary>
        public const string GPREIMCRCY = "GPREIMCRCY";

        /// <summary>
        /// GPAPPREQD.
        /// </summary>
        public const string GPAPPREQD = "GPAPPREQD";

        /// <summary>
        /// GPACCTGMD.
        /// </summary>
        public const string GPACCTGMD = "GPACCTGMD";

        /// <summary>
        /// GPDFLTCO.
        /// </summary>
        public const string GPDFLTCO = "GPDFLTCO";

        /// <summary>
        /// GPCCRCRCY.
        /// </summary>
        public const string GPCCRCRCY = "GPCCRCRCY";

        /// <summary>
        /// GPAN8.
        /// </summary>
        public const string GPAN8 = "GPAN8";

        /// <summary>
        /// GPUCSHADV.
        /// </summary>
        public const string GPUCSHADV = "GPUCSHADV";

        /// <summary>
        /// GPPID.
        /// </summary>
        public const string GPPID = "GPPID";

        /// <summary>
        /// GPJOBN.
        /// </summary>
        public const string GPJOBN = "GPJOBN";

        /// <summary>
        /// GPUSER.
        /// </summary>
        public const string GPUSER = "GPUSER";

        /// <summary>
        /// GPUPMJ.
        /// </summary>
        public const string GPUPMJ = "GPUPMJ";

        /// <summary>
        /// GPUPMT.
        /// </summary>
        public const string GPUPMT = "GPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F20104";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GPGRPPROF", "GPGRPPROF", JdeDataType.String, 10, true, true),
        new JdeField("GPDL01", "GPDL01", JdeDataType.String, 60),
        new JdeField("GPPOLICY", "GPPOLICY", JdeDataType.String, 10),
        new JdeField("GPEXRTID", "GPEXRTID", JdeDataType.String, 4),
        new JdeField("GPREIMMETH", "GPREIMMETH", JdeDataType.String, 4),
        new JdeField("GPREIMCRCY", "GPREIMCRCY", JdeDataType.String, 6),
        new JdeField("GPAPPREQD", "GPAPPREQD", JdeDataType.String, 2),
        new JdeField("GPACCTGMD", "GPACCTGMD", JdeDataType.String, 2),
        new JdeField("GPDFLTCO", "GPDFLTCO", JdeDataType.String, 10),
        new JdeField("GPCCRCRCY", "GPCCRCRCY", JdeDataType.String, 6),
        new JdeField("GPAN8", "GPAN8", JdeDataType.Numeric),
        new JdeField("GPUCSHADV", "GPUCSHADV", JdeDataType.String, 2),
        new JdeField("GPPID", "GPPID", JdeDataType.String, 20),
        new JdeField("GPJOBN", "GPJOBN", JdeDataType.String, 20),
        new JdeField("GPUSER", "GPUSER", JdeDataType.String, 20),
        new JdeField("GPUPMJ", "GPUPMJ", JdeDataType.Numeric),
        new JdeField("GPUPMT", "GPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F20104_0", "Primary Key on GPGRPPROF", new[] { "GPGRPPROF" }, isUnique: true, isPrimaryKey: true)
    };
}
