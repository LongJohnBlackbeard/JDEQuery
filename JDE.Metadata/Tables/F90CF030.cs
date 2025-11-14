using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CF030 - .
/// </summary>
public class F90CF030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AVANSWID.
        /// </summary>
        public const string AVANSWID = "AVANSWID";

        /// <summary>
        /// AVANSETID.
        /// </summary>
        public const string AVANSETID = "AVANSETID";

        /// <summary>
        /// AVANSRORDR.
        /// </summary>
        public const string AVANSRORDR = "AVANSRORDR";

        /// <summary>
        /// AVANSSCR.
        /// </summary>
        public const string AVANSSCR = "AVANSSCR";

        /// <summary>
        /// AVANSDEFFG.
        /// </summary>
        public const string AVANSDEFFG = "AVANSDEFFG";

        /// <summary>
        /// AVANSENFG.
        /// </summary>
        public const string AVANSENFG = "AVANSENFG";

        /// <summary>
        /// AVANSVAL.
        /// </summary>
        public const string AVANSVAL = "AVANSVAL";

        /// <summary>
        /// AVUSER.
        /// </summary>
        public const string AVUSER = "AVUSER";

        /// <summary>
        /// AVJOBN.
        /// </summary>
        public const string AVJOBN = "AVJOBN";

        /// <summary>
        /// AVMKEY.
        /// </summary>
        public const string AVMKEY = "AVMKEY";

        /// <summary>
        /// AVUDTTM.
        /// </summary>
        public const string AVUDTTM = "AVUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CF030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AVANSWID", "AVANSWID", JdeDataType.Numeric, null, true, true),
        new JdeField("AVANSETID", "AVANSETID", JdeDataType.Numeric),
        new JdeField("AVANSRORDR", "AVANSRORDR", JdeDataType.Numeric),
        new JdeField("AVANSSCR", "AVANSSCR", JdeDataType.Numeric),
        new JdeField("AVANSDEFFG", "AVANSDEFFG", JdeDataType.String, 2),
        new JdeField("AVANSENFG", "AVANSENFG", JdeDataType.String, 2),
        new JdeField("AVANSVAL", "AVANSVAL", JdeDataType.String, 510),
        new JdeField("AVUSER", "AVUSER", JdeDataType.String, 20),
        new JdeField("AVJOBN", "AVJOBN", JdeDataType.String, 20),
        new JdeField("AVMKEY", "AVMKEY", JdeDataType.String, 30),
        new JdeField("AVUDTTM", "AVUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CF030_0", "Primary Key on AVANSWID", new[] { "AVANSWID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CF030_2", "Index on AVANSETID, AVANSWID", new[] { "AVANSETID", "AVANSWID" })
    };
}
