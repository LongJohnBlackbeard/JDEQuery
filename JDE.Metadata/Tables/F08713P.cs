using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08713P - .
/// </summary>
public class F08713P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PIAN8.
        /// </summary>
        public const string PIAN8 = "PIAN8";

        /// <summary>
        /// PIUPMT.
        /// </summary>
        public const string PIUPMT = "PIUPMT";

        /// <summary>
        /// PIUPMJ.
        /// </summary>
        public const string PIUPMJ = "PIUPMJ";

        /// <summary>
        /// PIUSER.
        /// </summary>
        public const string PIUSER = "PIUSER";

        /// <summary>
        /// PIPID.
        /// </summary>
        public const string PIPID = "PIPID";

        /// <summary>
        /// PIJOBN.
        /// </summary>
        public const string PIJOBN = "PIJOBN";

        /// <summary>
        /// PIPIT.
        /// </summary>
        public const string PIPIT = "PIPIT";

        /// <summary>
        /// PIMKPUB.
        /// </summary>
        public const string PIMKPUB = "PIMKPUB";
    }

    /// <inheritdoc />
    public override string TableName => "F08713P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIAN8", "PIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PIUPMT", "PIUPMT", JdeDataType.Numeric),
        new JdeField("PIUPMJ", "PIUPMJ", JdeDataType.Numeric),
        new JdeField("PIUSER", "PIUSER", JdeDataType.String, 20),
        new JdeField("PIPID", "PIPID", JdeDataType.String, 20),
        new JdeField("PIJOBN", "PIJOBN", JdeDataType.String, 20),
        new JdeField("PIPIT", "PIPIT", JdeDataType.String, 60, true, true),
        new JdeField("PIMKPUB", "PIMKPUB", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08713P_0", "Primary Key on PIAN8, PIPIT", new[] { "PIAN8", "PIPIT" }, isUnique: true, isPrimaryKey: true)
    };
}
