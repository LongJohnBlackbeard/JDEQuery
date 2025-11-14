using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V410 - .
/// </summary>
public class F76V410 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TUCO.
        /// </summary>
        public const string TUCO = "TUCO";

        /// <summary>
        /// TUEFFF.
        /// </summary>
        public const string TUEFFF = "TUEFFF";

        /// <summary>
        /// TUEFFT.
        /// </summary>
        public const string TUEFFT = "TUEFFT";

        /// <summary>
        /// TUV76TRUN.
        /// </summary>
        public const string TUV76TRUN = "TUV76TRUN";

        /// <summary>
        /// TUUSER.
        /// </summary>
        public const string TUUSER = "TUUSER";

        /// <summary>
        /// TUPID.
        /// </summary>
        public const string TUPID = "TUPID";

        /// <summary>
        /// TUJOBN.
        /// </summary>
        public const string TUJOBN = "TUJOBN";

        /// <summary>
        /// TUUPMJ.
        /// </summary>
        public const string TUUPMJ = "TUUPMJ";

        /// <summary>
        /// TUUPMT.
        /// </summary>
        public const string TUUPMT = "TUUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76V410";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TUCO", "TUCO", JdeDataType.String, 10, true, true),
        new JdeField("TUEFFF", "TUEFFF", JdeDataType.Numeric, null, true, true),
        new JdeField("TUEFFT", "TUEFFT", JdeDataType.Numeric, null, true, true),
        new JdeField("TUV76TRUN", "TUV76TRUN", JdeDataType.Numeric),
        new JdeField("TUUSER", "TUUSER", JdeDataType.String, 20),
        new JdeField("TUPID", "TUPID", JdeDataType.String, 20),
        new JdeField("TUJOBN", "TUJOBN", JdeDataType.String, 20),
        new JdeField("TUUPMJ", "TUUPMJ", JdeDataType.Numeric),
        new JdeField("TUUPMT", "TUUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V410_0", "Primary Key on TUCO, TUEFFF, TUEFFT", new[] { "TUCO", "TUEFFF", "TUEFFT" }, isUnique: true, isPrimaryKey: true)
    };
}
