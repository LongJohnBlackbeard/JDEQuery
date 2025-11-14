using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I3051 - .
/// </summary>
public class F75I3051 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FYYEXU.
        /// </summary>
        public const string FYYEXU = "FYYEXU";

        /// <summary>
        /// FYYRM.
        /// </summary>
        public const string FYYRM = "FYYRM";

        /// <summary>
        /// FYYLYR.
        /// </summary>
        public const string FYYLYR = "FYYLYR";

        /// <summary>
        /// FYYN01.
        /// </summary>
        public const string FYYN01 = "FYYN01";

        /// <summary>
        /// FYCALYEAR.
        /// </summary>
        public const string FYCALYEAR = "FYCALYEAR";

        /// <summary>
        /// FYUSER.
        /// </summary>
        public const string FYUSER = "FYUSER";

        /// <summary>
        /// FYPID.
        /// </summary>
        public const string FYPID = "FYPID";

        /// <summary>
        /// FYJOBN.
        /// </summary>
        public const string FYJOBN = "FYJOBN";

        /// <summary>
        /// FYUPMJ.
        /// </summary>
        public const string FYUPMJ = "FYUPMJ";

        /// <summary>
        /// FYUPMT.
        /// </summary>
        public const string FYUPMT = "FYUPMT";

        /// <summary>
        /// FYEV01.
        /// </summary>
        public const string FYEV01 = "FYEV01";

        /// <summary>
        /// FYFLG.
        /// </summary>
        public const string FYFLG = "FYFLG";

        /// <summary>
        /// FYAA.
        /// </summary>
        public const string FYAA = "FYAA";

        /// <summary>
        /// FYDSC1.
        /// </summary>
        public const string FYDSC1 = "FYDSC1";

        /// <summary>
        /// FYDATE.
        /// </summary>
        public const string FYDATE = "FYDATE";

        /// <summary>
        /// FYAA1.
        /// </summary>
        public const string FYAA1 = "FYAA1";

        /// <summary>
        /// FYDTE.
        /// </summary>
        public const string FYDTE = "FYDTE";
    }

    /// <inheritdoc />
    public override string TableName => "F75I3051";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FYYEXU", "FYYEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("FYYRM", "FYYRM", JdeDataType.Numeric, null, true, true),
        new JdeField("FYYLYR", "FYYLYR", JdeDataType.Numeric, null, true, true),
        new JdeField("FYYN01", "FYYN01", JdeDataType.String, 2),
        new JdeField("FYCALYEAR", "FYCALYEAR", JdeDataType.Numeric),
        new JdeField("FYUSER", "FYUSER", JdeDataType.String, 20),
        new JdeField("FYPID", "FYPID", JdeDataType.String, 20),
        new JdeField("FYJOBN", "FYJOBN", JdeDataType.String, 20),
        new JdeField("FYUPMJ", "FYUPMJ", JdeDataType.Numeric),
        new JdeField("FYUPMT", "FYUPMT", JdeDataType.Numeric),
        new JdeField("FYEV01", "FYEV01", JdeDataType.String, 2),
        new JdeField("FYFLG", "FYFLG", JdeDataType.String, 2),
        new JdeField("FYAA", "FYAA", JdeDataType.Numeric),
        new JdeField("FYDSC1", "FYDSC1", JdeDataType.String, 60),
        new JdeField("FYDATE", "FYDATE", JdeDataType.String, 16),
        new JdeField("FYAA1", "FYAA1", JdeDataType.Numeric),
        new JdeField("FYDTE", "FYDTE", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I3051_0", "Primary Key on FYYEXU, FYYRM, FYYLYR", new[] { "FYYEXU", "FYYRM", "FYYLYR" }, isUnique: true, isPrimaryKey: true)
    };
}
