using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3460SW - .
/// </summary>
public class F3460SW : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FSUSER.
        /// </summary>
        public const string FSUSER = "FSUSER";

        /// <summary>
        /// FSUKID.
        /// </summary>
        public const string FSUKID = "FSUKID";

        /// <summary>
        /// FSITM.
        /// </summary>
        public const string FSITM = "FSITM";

        /// <summary>
        /// FSMCU.
        /// </summary>
        public const string FSMCU = "FSMCU";

        /// <summary>
        /// FSTYPF.
        /// </summary>
        public const string FSTYPF = "FSTYPF";

        /// <summary>
        /// FSAN8.
        /// </summary>
        public const string FSAN8 = "FSAN8";

        /// <summary>
        /// FSFQT.
        /// </summary>
        public const string FSFQT = "FSFQT";

        /// <summary>
        /// FSFAM.
        /// </summary>
        public const string FSFAM = "FSFAM";
    }

    /// <inheritdoc />
    public override string TableName => "F3460SW";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FSUSER", "FSUSER", JdeDataType.String, 20, true, true),
        new JdeField("FSUKID", "FSUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("FSITM", "FSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("FSMCU", "FSMCU", JdeDataType.String, 24, true, true),
        new JdeField("FSTYPF", "FSTYPF", JdeDataType.String, 4, true, true),
        new JdeField("FSAN8", "FSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("FSFQT", "FSFQT", JdeDataType.Numeric),
        new JdeField("FSFAM", "FSFAM", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3460SW_0", "Primary Key on FSUSER, FSUKID, FSITM, FSMCU, FSTYPF, FSAN8", new[] { "FSUSER", "FSUKID", "FSITM", "FSMCU", "FSTYPF", "FSAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
