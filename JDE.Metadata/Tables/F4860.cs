using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4860 - .
/// </summary>
public class F4860 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AFCTBL.
        /// </summary>
        public const string AFCTBL = "AFCTBL";

        /// <summary>
        /// AFDL01.
        /// </summary>
        public const string AFDL01 = "AFDL01";

        /// <summary>
        /// AFEFTB.
        /// </summary>
        public const string AFEFTB = "AFEFTB";

        /// <summary>
        /// AFEFTE.
        /// </summary>
        public const string AFEFTE = "AFEFTE";

        /// <summary>
        /// AFCRCD.
        /// </summary>
        public const string AFCRCD = "AFCRCD";

        /// <summary>
        /// AFUSER.
        /// </summary>
        public const string AFUSER = "AFUSER";

        /// <summary>
        /// AFPID.
        /// </summary>
        public const string AFPID = "AFPID";

        /// <summary>
        /// AFJOBN.
        /// </summary>
        public const string AFJOBN = "AFJOBN";

        /// <summary>
        /// AFUPMJ.
        /// </summary>
        public const string AFUPMJ = "AFUPMJ";

        /// <summary>
        /// AFUPMT.
        /// </summary>
        public const string AFUPMT = "AFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F4860";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AFCTBL", "AFCTBL", JdeDataType.String, 20, true, true),
        new JdeField("AFDL01", "AFDL01", JdeDataType.String, 60),
        new JdeField("AFEFTB", "AFEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("AFEFTE", "AFEFTE", JdeDataType.Numeric),
        new JdeField("AFCRCD", "AFCRCD", JdeDataType.String, 6, true, true),
        new JdeField("AFUSER", "AFUSER", JdeDataType.String, 20),
        new JdeField("AFPID", "AFPID", JdeDataType.String, 20),
        new JdeField("AFJOBN", "AFJOBN", JdeDataType.String, 20),
        new JdeField("AFUPMJ", "AFUPMJ", JdeDataType.Numeric),
        new JdeField("AFUPMT", "AFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4860_0", "Primary Key on AFCTBL, AFCRCD, AFEFTB", new[] { "AFCTBL", "AFCRCD", "AFEFTB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4860_2", "Index on AFCTBL, AFCRCD", new[] { "AFCTBL", "AFCRCD" })
    };
}
