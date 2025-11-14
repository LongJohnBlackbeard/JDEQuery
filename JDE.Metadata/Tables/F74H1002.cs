using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74H1002 - .
/// </summary>
public class F74H1002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VB74HVBID.
        /// </summary>
        public const string VB74HVBID = "VB74HVBID";

        /// <summary>
        /// VBDL01.
        /// </summary>
        public const string VBDL01 = "VBDL01";

        /// <summary>
        /// VBDATE01.
        /// </summary>
        public const string VBDATE01 = "VBDATE01";

        /// <summary>
        /// VBJOBN.
        /// </summary>
        public const string VBJOBN = "VBJOBN";

        /// <summary>
        /// VBPID.
        /// </summary>
        public const string VBPID = "VBPID";

        /// <summary>
        /// VBUSER.
        /// </summary>
        public const string VBUSER = "VBUSER";

        /// <summary>
        /// VBUPMJ.
        /// </summary>
        public const string VBUPMJ = "VBUPMJ";

        /// <summary>
        /// VBUPMT.
        /// </summary>
        public const string VBUPMT = "VBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74H1002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VB74HVBID", "VB74HVBID", JdeDataType.Numeric, null, true, true),
        new JdeField("VBDL01", "VBDL01", JdeDataType.String, 60),
        new JdeField("VBDATE01", "VBDATE01", JdeDataType.Numeric),
        new JdeField("VBJOBN", "VBJOBN", JdeDataType.String, 20),
        new JdeField("VBPID", "VBPID", JdeDataType.String, 20),
        new JdeField("VBUSER", "VBUSER", JdeDataType.String, 20),
        new JdeField("VBUPMJ", "VBUPMJ", JdeDataType.Numeric),
        new JdeField("VBUPMT", "VBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74H1002_0", "Primary Key on VB74HVBID", new[] { "VB74HVBID" }, isUnique: true, isPrimaryKey: true)
    };
}
