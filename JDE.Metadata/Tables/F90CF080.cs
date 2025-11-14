using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CF080 - .
/// </summary>
public class F90CF080 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SVVARLID.
        /// </summary>
        public const string SVVARLID = "SVVARLID";

        /// <summary>
        /// SVVARNAM.
        /// </summary>
        public const string SVVARNAM = "SVVARNAM";

        /// <summary>
        /// SVVARLTYPE.
        /// </summary>
        public const string SVVARLTYPE = "SVVARLTYPE";

        /// <summary>
        /// SVVARATT.
        /// </summary>
        public const string SVVARATT = "SVVARATT";

        /// <summary>
        /// SVVARLDESC.
        /// </summary>
        public const string SVVARLDESC = "SVVARLDESC";

        /// <summary>
        /// SVUSER.
        /// </summary>
        public const string SVUSER = "SVUSER";

        /// <summary>
        /// SVJOBN.
        /// </summary>
        public const string SVJOBN = "SVJOBN";

        /// <summary>
        /// SVMKEY.
        /// </summary>
        public const string SVMKEY = "SVMKEY";

        /// <summary>
        /// SVUDTTM.
        /// </summary>
        public const string SVUDTTM = "SVUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CF080";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SVVARLID", "SVVARLID", JdeDataType.Numeric, null, true, true),
        new JdeField("SVVARNAM", "SVVARNAM", JdeDataType.String, 80),
        new JdeField("SVVARLTYPE", "SVVARLTYPE", JdeDataType.String, 8),
        new JdeField("SVVARATT", "SVVARATT", JdeDataType.String, 30),
        new JdeField("SVVARLDESC", "SVVARLDESC", JdeDataType.String, 508),
        new JdeField("SVUSER", "SVUSER", JdeDataType.String, 20),
        new JdeField("SVJOBN", "SVJOBN", JdeDataType.String, 20),
        new JdeField("SVMKEY", "SVMKEY", JdeDataType.String, 30),
        new JdeField("SVUDTTM", "SVUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CF080_0", "Primary Key on SVVARLID", new[] { "SVVARLID" }, isUnique: true, isPrimaryKey: true)
    };
}
