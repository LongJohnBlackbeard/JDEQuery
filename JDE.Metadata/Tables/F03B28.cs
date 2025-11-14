using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B28 - .
/// </summary>
public class F03B28 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RJLTNA.
        /// </summary>
        public const string RJLTNA = "RJLTNA";

        /// <summary>
        /// RJLTTY.
        /// </summary>
        public const string RJLTTY = "RJLTTY";

        /// <summary>
        /// RJLNGP.
        /// </summary>
        public const string RJLNGP = "RJLNGP";

        /// <summary>
        /// RJDESC.
        /// </summary>
        public const string RJDESC = "RJDESC";

        /// <summary>
        /// RJUSER.
        /// </summary>
        public const string RJUSER = "RJUSER";

        /// <summary>
        /// RJPID.
        /// </summary>
        public const string RJPID = "RJPID";

        /// <summary>
        /// RJJOBN.
        /// </summary>
        public const string RJJOBN = "RJJOBN";

        /// <summary>
        /// RJUPMJ.
        /// </summary>
        public const string RJUPMJ = "RJUPMJ";

        /// <summary>
        /// RJUPMT.
        /// </summary>
        public const string RJUPMT = "RJUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F03B28";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RJLTNA", "RJLTNA", JdeDataType.String, 20, true, true),
        new JdeField("RJLTTY", "RJLTTY", JdeDataType.String, 2, true, true),
        new JdeField("RJLNGP", "RJLNGP", JdeDataType.String, 4, true, true),
        new JdeField("RJDESC", "RJDESC", JdeDataType.String, 60),
        new JdeField("RJUSER", "RJUSER", JdeDataType.String, 20),
        new JdeField("RJPID", "RJPID", JdeDataType.String, 20),
        new JdeField("RJJOBN", "RJJOBN", JdeDataType.String, 20),
        new JdeField("RJUPMJ", "RJUPMJ", JdeDataType.Numeric),
        new JdeField("RJUPMT", "RJUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B28_0", "Primary Key on RJLTNA, RJLTTY, RJLNGP", new[] { "RJLTNA", "RJLTTY", "RJLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
