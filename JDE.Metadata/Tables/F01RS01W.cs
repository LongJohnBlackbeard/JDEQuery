using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01RS01W - .
/// </summary>
public class F01RS01W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// THSESSID.
        /// </summary>
        public const string THSESSID = "THSESSID";

        /// <summary>
        /// THRLTYPE.
        /// </summary>
        public const string THRLTYPE = "THRLTYPE";

        /// <summary>
        /// THTASKID.
        /// </summary>
        public const string THTASKID = "THTASKID";

        /// <summary>
        /// THTASKNM.
        /// </summary>
        public const string THTASKNM = "THTASKNM";

        /// <summary>
        /// THLNGTASK.
        /// </summary>
        public const string THLNGTASK = "THLNGTASK";

        /// <summary>
        /// THTASKTYPE.
        /// </summary>
        public const string THTASKTYPE = "THTASKTYPE";
    }

    /// <inheritdoc />
    public override string TableName => "F01RS01W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("THSESSID", "THSESSID", JdeDataType.String, 64, true, true),
        new JdeField("THRLTYPE", "THRLTYPE", JdeDataType.String, 10, true, true),
        new JdeField("THTASKID", "THTASKID", JdeDataType.String, 72),
        new JdeField("THTASKNM", "THTASKNM", JdeDataType.String, 80),
        new JdeField("THLNGTASK", "THLNGTASK", JdeDataType.String, 160),
        new JdeField("THTASKTYPE", "THTASKTYPE", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01RS01W_0", "Primary Key on THSESSID, THRLTYPE", new[] { "THSESSID", "THRLTYPE" }, isUnique: true, isPrimaryKey: true)
    };
}
