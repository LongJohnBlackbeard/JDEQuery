using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F054115 - .
/// </summary>
public class F054115 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HPAN8.
        /// </summary>
        public const string HPAN8 = "HPAN8";

        /// <summary>
        /// HPRCK7.
        /// </summary>
        public const string HPRCK7 = "HPRCK7";

        /// <summary>
        /// HPIDLN.
        /// </summary>
        public const string HPIDLN = "HPIDLN";

        /// <summary>
        /// HPAR1.
        /// </summary>
        public const string HPAR1 = "HPAR1";

        /// <summary>
        /// HPPH1.
        /// </summary>
        public const string HPPH1 = "HPPH1";

        /// <summary>
        /// HPPHTP.
        /// </summary>
        public const string HPPHTP = "HPPHTP";

        /// <summary>
        /// HPUSER.
        /// </summary>
        public const string HPUSER = "HPUSER";

        /// <summary>
        /// HPPID.
        /// </summary>
        public const string HPPID = "HPPID";

        /// <summary>
        /// HPJOBN.
        /// </summary>
        public const string HPJOBN = "HPJOBN";

        /// <summary>
        /// HPUPMJ.
        /// </summary>
        public const string HPUPMJ = "HPUPMJ";

        /// <summary>
        /// HPUPMT.
        /// </summary>
        public const string HPUPMT = "HPUPMT";

        /// <summary>
        /// HPESIGN.
        /// </summary>
        public const string HPESIGN = "HPESIGN";

        /// <summary>
        /// HPMUMJ.
        /// </summary>
        public const string HPMUMJ = "HPMUMJ";

        /// <summary>
        /// HPMUMT.
        /// </summary>
        public const string HPMUMT = "HPMUMT";

        /// <summary>
        /// HPUPID.
        /// </summary>
        public const string HPUPID = "HPUPID";
    }

    /// <inheritdoc />
    public override string TableName => "F054115";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HPAN8", "HPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("HPRCK7", "HPRCK7", JdeDataType.Numeric, null, true, true),
        new JdeField("HPIDLN", "HPIDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("HPAR1", "HPAR1", JdeDataType.String, 12),
        new JdeField("HPPH1", "HPPH1", JdeDataType.String, 40),
        new JdeField("HPPHTP", "HPPHTP", JdeDataType.String, 8),
        new JdeField("HPUSER", "HPUSER", JdeDataType.String, 20),
        new JdeField("HPPID", "HPPID", JdeDataType.String, 20),
        new JdeField("HPJOBN", "HPJOBN", JdeDataType.String, 20),
        new JdeField("HPUPMJ", "HPUPMJ", JdeDataType.Numeric),
        new JdeField("HPUPMT", "HPUPMT", JdeDataType.Numeric),
        new JdeField("HPESIGN", "HPESIGN", JdeDataType.String, 32, true, true),
        new JdeField("HPMUMJ", "HPMUMJ", JdeDataType.Numeric),
        new JdeField("HPMUMT", "HPMUMT", JdeDataType.Numeric),
        new JdeField("HPUPID", "HPUPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F054115_0", "Primary Key on HPAN8, HPIDLN, HPRCK7, HPESIGN", new[] { "HPAN8", "HPIDLN", "HPRCK7", "HPESIGN" }, isUnique: true, isPrimaryKey: true)
    };
}
