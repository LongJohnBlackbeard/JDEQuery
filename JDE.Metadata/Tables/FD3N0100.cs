using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N0100 - .
/// </summary>
public class FD3N0100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PTDTI1.
        /// </summary>
        public const string PTDTI1 = "PTDTI1";

        /// <summary>
        /// PTDESC.
        /// </summary>
        public const string PTDESC = "PTDESC";

        /// <summary>
        /// PTDYUD.
        /// </summary>
        public const string PTDYUD = "PTDYUD";

        /// <summary>
        /// PTENAB.
        /// </summary>
        public const string PTENAB = "PTENAB";

        /// <summary>
        /// PTEDD0.
        /// </summary>
        public const string PTEDD0 = "PTEDD0";

        /// <summary>
        /// PTEDQD.
        /// </summary>
        public const string PTEDQD = "PTEDQD";

        /// <summary>
        /// PTAOYN.
        /// </summary>
        public const string PTAOYN = "PTAOYN";

        /// <summary>
        /// PTUSER.
        /// </summary>
        public const string PTUSER = "PTUSER";

        /// <summary>
        /// PTPID.
        /// </summary>
        public const string PTPID = "PTPID";

        /// <summary>
        /// PTUPMJ.
        /// </summary>
        public const string PTUPMJ = "PTUPMJ";

        /// <summary>
        /// PTJOBN.
        /// </summary>
        public const string PTJOBN = "PTJOBN";

        /// <summary>
        /// PTUPMT.
        /// </summary>
        public const string PTUPMT = "PTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N0100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PTDTI1", "PTDTI1", JdeDataType.String, 20, true, true),
        new JdeField("PTDESC", "PTDESC", JdeDataType.String, 60),
        new JdeField("PTDYUD", "PTDYUD", JdeDataType.Numeric),
        new JdeField("PTENAB", "PTENAB", JdeDataType.String, 2),
        new JdeField("PTEDD0", "PTEDD0", JdeDataType.Numeric),
        new JdeField("PTEDQD", "PTEDQD", JdeDataType.Numeric),
        new JdeField("PTAOYN", "PTAOYN", JdeDataType.String, 2),
        new JdeField("PTUSER", "PTUSER", JdeDataType.String, 20),
        new JdeField("PTPID", "PTPID", JdeDataType.String, 20),
        new JdeField("PTUPMJ", "PTUPMJ", JdeDataType.Numeric),
        new JdeField("PTJOBN", "PTJOBN", JdeDataType.String, 20),
        new JdeField("PTUPMT", "PTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N0100_0", "Primary Key on PTDTI1", new[] { "PTDTI1" }, isUnique: true, isPrimaryKey: true)
    };
}
