using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1303 - .
/// </summary>
public class F1303 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FJCO.
        /// </summary>
        public const string FJCO = "FJCO";

        /// <summary>
        /// FJLOC.
        /// </summary>
        public const string FJLOC = "FJLOC";

        /// <summary>
        /// FJCTRY.
        /// </summary>
        public const string FJCTRY = "FJCTRY";

        /// <summary>
        /// FJDTEM.
        /// </summary>
        public const string FJDTEM = "FJDTEM";

        /// <summary>
        /// FJDTED.
        /// </summary>
        public const string FJDTED = "FJDTED";

        /// <summary>
        /// FJDTEY.
        /// </summary>
        public const string FJDTEY = "FJDTEY";

        /// <summary>
        /// FJINEX.
        /// </summary>
        public const string FJINEX = "FJINEX";

        /// <summary>
        /// FJLCT.
        /// </summary>
        public const string FJLCT = "FJLCT";

        /// <summary>
        /// FJUSER.
        /// </summary>
        public const string FJUSER = "FJUSER";

        /// <summary>
        /// FJPID.
        /// </summary>
        public const string FJPID = "FJPID";

        /// <summary>
        /// FJJOBN.
        /// </summary>
        public const string FJJOBN = "FJJOBN";

        /// <summary>
        /// FJUPMT.
        /// </summary>
        public const string FJUPMT = "FJUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1303";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FJCO", "FJCO", JdeDataType.String, 10, true, true),
        new JdeField("FJLOC", "FJLOC", JdeDataType.String, 24, true, true),
        new JdeField("FJCTRY", "FJCTRY", JdeDataType.Numeric),
        new JdeField("FJDTEM", "FJDTEM", JdeDataType.Numeric, null, true, true),
        new JdeField("FJDTED", "FJDTED", JdeDataType.Numeric, null, true, true),
        new JdeField("FJDTEY", "FJDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("FJINEX", "FJINEX", JdeDataType.String, 2),
        new JdeField("FJLCT", "FJLCT", JdeDataType.Numeric),
        new JdeField("FJUSER", "FJUSER", JdeDataType.String, 20),
        new JdeField("FJPID", "FJPID", JdeDataType.String, 20),
        new JdeField("FJJOBN", "FJJOBN", JdeDataType.String, 20),
        new JdeField("FJUPMT", "FJUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1303_0", "Primary Key on FJCO, FJLOC, FJDTEY, FJDTEM, FJDTED", new[] { "FJCO", "FJLOC", "FJDTEY", "FJDTEM", "FJDTED" }, isUnique: true, isPrimaryKey: true)
    };
}
