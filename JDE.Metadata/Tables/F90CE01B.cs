using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CE01B - .
/// </summary>
public class F90CE01B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCSLTNID.
        /// </summary>
        public const string SCSLTNID = "SCSLTNID";

        /// <summary>
        /// SCDOCO.
        /// </summary>
        public const string SCDOCO = "SCDOCO";

        /// <summary>
        /// SCSETID.
        /// </summary>
        public const string SCSETID = "SCSETID";

        /// <summary>
        /// SCENTDBY.
        /// </summary>
        public const string SCENTDBY = "SCENTDBY";

        /// <summary>
        /// SCEDATE.
        /// </summary>
        public const string SCEDATE = "SCEDATE";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCUDTTM.
        /// </summary>
        public const string SCUDTTM = "SCUDTTM";

        /// <summary>
        /// SCMKEY.
        /// </summary>
        public const string SCMKEY = "SCMKEY";

        /// <summary>
        /// SCSLLKST.
        /// </summary>
        public const string SCSLLKST = "SCSLLKST";
    }

    /// <inheritdoc />
    public override string TableName => "F90CE01B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCSLTNID", "SCSLTNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SCDOCO", "SCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SCSETID", "SCSETID", JdeDataType.String, 10),
        new JdeField("SCENTDBY", "SCENTDBY", JdeDataType.Numeric),
        new JdeField("SCEDATE", "SCEDATE", JdeDataType.Date),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCUDTTM", "SCUDTTM", JdeDataType.Date),
        new JdeField("SCMKEY", "SCMKEY", JdeDataType.String, 30),
        new JdeField("SCSLLKST", "SCSLLKST", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CE01B_0", "Primary Key on SCSLTNID, SCDOCO", new[] { "SCSLTNID", "SCDOCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CE01B_2", "Index on SCDOCO", new[] { "SCDOCO" })
    };
}
