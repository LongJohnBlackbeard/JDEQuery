using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1544BD - .
/// </summary>
public class F1544BD : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OBSASC.
        /// </summary>
        public const string OBSASC = "OBSASC";

        /// <summary>
        /// OBLNGP.
        /// </summary>
        public const string OBLNGP = "OBLNGP";

        /// <summary>
        /// OBDL01.
        /// </summary>
        public const string OBDL01 = "OBDL01";

        /// <summary>
        /// OBCOL1.
        /// </summary>
        public const string OBCOL1 = "OBCOL1";

        /// <summary>
        /// OBCOL2.
        /// </summary>
        public const string OBCOL2 = "OBCOL2";

        /// <summary>
        /// OBUSER.
        /// </summary>
        public const string OBUSER = "OBUSER";

        /// <summary>
        /// OBPID.
        /// </summary>
        public const string OBPID = "OBPID";

        /// <summary>
        /// OBUPMJ.
        /// </summary>
        public const string OBUPMJ = "OBUPMJ";

        /// <summary>
        /// OBUPMT.
        /// </summary>
        public const string OBUPMT = "OBUPMT";

        /// <summary>
        /// OBJOBN.
        /// </summary>
        public const string OBJOBN = "OBJOBN";

        /// <summary>
        /// OBTORG.
        /// </summary>
        public const string OBTORG = "OBTORG";

        /// <summary>
        /// OBENTJ.
        /// </summary>
        public const string OBENTJ = "OBENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1544BD";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OBSASC", "OBSASC", JdeDataType.String, 4, true, true),
        new JdeField("OBLNGP", "OBLNGP", JdeDataType.String, 4, true, true),
        new JdeField("OBDL01", "OBDL01", JdeDataType.String, 60),
        new JdeField("OBCOL1", "OBCOL1", JdeDataType.String, 30),
        new JdeField("OBCOL2", "OBCOL2", JdeDataType.String, 30),
        new JdeField("OBUSER", "OBUSER", JdeDataType.String, 20),
        new JdeField("OBPID", "OBPID", JdeDataType.String, 20),
        new JdeField("OBUPMJ", "OBUPMJ", JdeDataType.Numeric),
        new JdeField("OBUPMT", "OBUPMT", JdeDataType.Numeric),
        new JdeField("OBJOBN", "OBJOBN", JdeDataType.String, 20),
        new JdeField("OBTORG", "OBTORG", JdeDataType.String, 20),
        new JdeField("OBENTJ", "OBENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1544BD_0", "Primary Key on OBSASC, OBLNGP", new[] { "OBSASC", "OBLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
