using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7430024 - .
/// </summary>
public class F7430024 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DUK74LECO.
        /// </summary>
        public const string DUK74LECO = "DUK74LECO";

        /// <summary>
        /// DUK74LEDT.
        /// </summary>
        public const string DUK74LEDT = "DUK74LEDT";

        /// <summary>
        /// DUK74ISPL.
        /// </summary>
        public const string DUK74ISPL = "DUK74ISPL";

        /// <summary>
        /// DUUSER1.
        /// </summary>
        public const string DUUSER1 = "DUUSER1";

        /// <summary>
        /// DUPID1.
        /// </summary>
        public const string DUPID1 = "DUPID1";

        /// <summary>
        /// DUVERS.
        /// </summary>
        public const string DUVERS = "DUVERS";

        /// <summary>
        /// DUUSER.
        /// </summary>
        public const string DUUSER = "DUUSER";

        /// <summary>
        /// DUPID.
        /// </summary>
        public const string DUPID = "DUPID";

        /// <summary>
        /// DUJOBN.
        /// </summary>
        public const string DUJOBN = "DUJOBN";

        /// <summary>
        /// DUUPMT.
        /// </summary>
        public const string DUUPMT = "DUUPMT";

        /// <summary>
        /// DUUPMJ.
        /// </summary>
        public const string DUUPMJ = "DUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F7430024";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DUK74LECO", "DUK74LECO", JdeDataType.String, 10, true, true),
        new JdeField("DUK74LEDT", "DUK74LEDT", JdeDataType.String, 10, true, true),
        new JdeField("DUK74ISPL", "DUK74ISPL", JdeDataType.String, 30, true, true),
        new JdeField("DUUSER1", "DUUSER1", JdeDataType.String, 20, true, true),
        new JdeField("DUPID1", "DUPID1", JdeDataType.String, 20),
        new JdeField("DUVERS", "DUVERS", JdeDataType.String, 20),
        new JdeField("DUUSER", "DUUSER", JdeDataType.String, 20),
        new JdeField("DUPID", "DUPID", JdeDataType.String, 20),
        new JdeField("DUJOBN", "DUJOBN", JdeDataType.String, 20),
        new JdeField("DUUPMT", "DUUPMT", JdeDataType.Numeric),
        new JdeField("DUUPMJ", "DUUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7430024_0", "Primary Key on DUK74LECO, DUK74LEDT, DUK74ISPL, DUUSER1", new[] { "DUK74LECO", "DUK74LEDT", "DUK74ISPL", "DUUSER1" }, isUnique: true, isPrimaryKey: true)
    };
}
