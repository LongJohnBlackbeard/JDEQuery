using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U210W - .
/// </summary>
public class F74U210W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PLPID.
        /// </summary>
        public const string PLPID = "PLPID";

        /// <summary>
        /// PLJOBN.
        /// </summary>
        public const string PLJOBN = "PLJOBN";

        /// <summary>
        /// PLUPMJ.
        /// </summary>
        public const string PLUPMJ = "PLUPMJ";

        /// <summary>
        /// PLUPMT.
        /// </summary>
        public const string PLUPMT = "PLUPMT";

        /// <summary>
        /// PLDOCO.
        /// </summary>
        public const string PLDOCO = "PLDOCO";

        /// <summary>
        /// PLLSVR.
        /// </summary>
        public const string PLLSVR = "PLLSVR";

        /// <summary>
        /// PL74UCRCD.
        /// </summary>
        public const string PL74UCRCD = "PL74UCRCD";

        /// <summary>
        /// PL74UGAMT.
        /// </summary>
        public const string PL74UGAMT = "PL74UGAMT";

        /// <summary>
        /// PLUSER.
        /// </summary>
        public const string PLUSER = "PLUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F74U210W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PLPID", "PLPID", JdeDataType.String, 20, true, true),
        new JdeField("PLJOBN", "PLJOBN", JdeDataType.String, 20, true, true),
        new JdeField("PLUPMJ", "PLUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PLUPMT", "PLUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("PLDOCO", "PLDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PLLSVR", "PLLSVR", JdeDataType.Numeric, null, true, true),
        new JdeField("PL74UCRCD", "PL74UCRCD", JdeDataType.String, 6, true, true),
        new JdeField("PL74UGAMT", "PL74UGAMT", JdeDataType.Numeric),
        new JdeField("PLUSER", "PLUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U210W_0", "Primary Key on PLPID, PLJOBN, PLUPMJ, PLUPMT, PLDOCO, PLLSVR, PL74UCRCD", new[] { "PLPID", "PLJOBN", "PLUPMJ", "PLUPMT", "PLDOCO", "PLLSVR", "PL74UCRCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U210W_2", "Index on PLPID, PLJOBN, PLUPMJ, PLUPMT, PL74UCRCD", new[] { "PLPID", "PLJOBN", "PLUPMJ", "PLUPMT", "PL74UCRCD" })
    };
}
