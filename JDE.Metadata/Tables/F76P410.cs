using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76P410 - .
/// </summary>
public class F76P410 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SPCO.
        /// </summary>
        public const string SPCO = "SPCO";

        /// <summary>
        /// SPP76CC02.
        /// </summary>
        public const string SPP76CC02 = "SPP76CC02";

        /// <summary>
        /// SPEFTJ.
        /// </summary>
        public const string SPEFTJ = "SPEFTJ";

        /// <summary>
        /// SPEFDJ.
        /// </summary>
        public const string SPEFDJ = "SPEFDJ";

        /// <summary>
        /// SPP76WHPC.
        /// </summary>
        public const string SPP76WHPC = "SPP76WHPC";

        /// <summary>
        /// SPP76WHMA.
        /// </summary>
        public const string SPP76WHMA = "SPP76WHMA";

        /// <summary>
        /// SPP76WHAT.
        /// </summary>
        public const string SPP76WHAT = "SPP76WHAT";

        /// <summary>
        /// SPH76FUA.
        /// </summary>
        public const string SPH76FUA = "SPH76FUA";

        /// <summary>
        /// SPH76FUC.
        /// </summary>
        public const string SPH76FUC = "SPH76FUC";

        /// <summary>
        /// SPH76FUD.
        /// </summary>
        public const string SPH76FUD = "SPH76FUD";

        /// <summary>
        /// SPH76FUR.
        /// </summary>
        public const string SPH76FUR = "SPH76FUR";

        /// <summary>
        /// SPH76FUF.
        /// </summary>
        public const string SPH76FUF = "SPH76FUF";

        /// <summary>
        /// SPUSER.
        /// </summary>
        public const string SPUSER = "SPUSER";

        /// <summary>
        /// SPPID.
        /// </summary>
        public const string SPPID = "SPPID";

        /// <summary>
        /// SPJOBN.
        /// </summary>
        public const string SPJOBN = "SPJOBN";

        /// <summary>
        /// SPUPMJ.
        /// </summary>
        public const string SPUPMJ = "SPUPMJ";

        /// <summary>
        /// SPUPMT.
        /// </summary>
        public const string SPUPMT = "SPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76P410";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SPCO", "SPCO", JdeDataType.String, 10, true, true),
        new JdeField("SPP76CC02", "SPP76CC02", JdeDataType.String, 6, true, true),
        new JdeField("SPEFTJ", "SPEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("SPEFDJ", "SPEFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("SPP76WHPC", "SPP76WHPC", JdeDataType.Numeric),
        new JdeField("SPP76WHMA", "SPP76WHMA", JdeDataType.Numeric),
        new JdeField("SPP76WHAT", "SPP76WHAT", JdeDataType.String, 2),
        new JdeField("SPH76FUA", "SPH76FUA", JdeDataType.Numeric),
        new JdeField("SPH76FUC", "SPH76FUC", JdeDataType.String, 20),
        new JdeField("SPH76FUD", "SPH76FUD", JdeDataType.Numeric),
        new JdeField("SPH76FUR", "SPH76FUR", JdeDataType.String, 30),
        new JdeField("SPH76FUF", "SPH76FUF", JdeDataType.String, 2),
        new JdeField("SPUSER", "SPUSER", JdeDataType.String, 20),
        new JdeField("SPPID", "SPPID", JdeDataType.String, 20),
        new JdeField("SPJOBN", "SPJOBN", JdeDataType.String, 20),
        new JdeField("SPUPMJ", "SPUPMJ", JdeDataType.Numeric),
        new JdeField("SPUPMT", "SPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76P410_0", "Primary Key on SPCO, SPP76CC02, SPEFTJ, SPEFDJ", new[] { "SPCO", "SPP76CC02", "SPEFTJ", "SPEFDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
