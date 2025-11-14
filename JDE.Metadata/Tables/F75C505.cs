using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C505 - .
/// </summary>
public class F75C505 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PEC75PEID.
        /// </summary>
        public const string PEC75PEID = "PEC75PEID";

        /// <summary>
        /// PEC75PENAM.
        /// </summary>
        public const string PEC75PENAM = "PEC75PENAM";

        /// <summary>
        /// PEFUTMATH1.
        /// </summary>
        public const string PEFUTMATH1 = "PEFUTMATH1";

        /// <summary>
        /// PEFUTSTR1.
        /// </summary>
        public const string PEFUTSTR1 = "PEFUTSTR1";

        /// <summary>
        /// PEFUTSTR2.
        /// </summary>
        public const string PEFUTSTR2 = "PEFUTSTR2";

        /// <summary>
        /// PEFUTDATE1.
        /// </summary>
        public const string PEFUTDATE1 = "PEFUTDATE1";

        /// <summary>
        /// PEFUTUO1.
        /// </summary>
        public const string PEFUTUO1 = "PEFUTUO1";

        /// <summary>
        /// PEUSER.
        /// </summary>
        public const string PEUSER = "PEUSER";

        /// <summary>
        /// PEPID.
        /// </summary>
        public const string PEPID = "PEPID";

        /// <summary>
        /// PEJOBN.
        /// </summary>
        public const string PEJOBN = "PEJOBN";

        /// <summary>
        /// PEUPMJ.
        /// </summary>
        public const string PEUPMJ = "PEUPMJ";

        /// <summary>
        /// PEUPMT.
        /// </summary>
        public const string PEUPMT = "PEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C505";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PEC75PEID", "PEC75PEID", JdeDataType.String, 120, true, true),
        new JdeField("PEC75PENAM", "PEC75PENAM", JdeDataType.String, 120),
        new JdeField("PEFUTMATH1", "PEFUTMATH1", JdeDataType.Numeric),
        new JdeField("PEFUTSTR1", "PEFUTSTR1", JdeDataType.String, 100),
        new JdeField("PEFUTSTR2", "PEFUTSTR2", JdeDataType.String, 100),
        new JdeField("PEFUTDATE1", "PEFUTDATE1", JdeDataType.Numeric),
        new JdeField("PEFUTUO1", "PEFUTUO1", JdeDataType.String, 2),
        new JdeField("PEUSER", "PEUSER", JdeDataType.String, 20),
        new JdeField("PEPID", "PEPID", JdeDataType.String, 20),
        new JdeField("PEJOBN", "PEJOBN", JdeDataType.String, 20),
        new JdeField("PEUPMJ", "PEUPMJ", JdeDataType.Numeric),
        new JdeField("PEUPMT", "PEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C505_0", "Primary Key on PEC75PEID", new[] { "PEC75PEID" }, isUnique: true, isPrimaryKey: true)
    };
}
