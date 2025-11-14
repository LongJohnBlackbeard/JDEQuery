using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C0006 - .
/// </summary>
public class F76C0006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ATKCO.
        /// </summary>
        public const string ATKCO = "ATKCO";

        /// <summary>
        /// ATDOC.
        /// </summary>
        public const string ATDOC = "ATDOC";

        /// <summary>
        /// ATDCT.
        /// </summary>
        public const string ATDCT = "ATDCT";

        /// <summary>
        /// ATSFX.
        /// </summary>
        public const string ATSFX = "ATSFX";

        /// <summary>
        /// ATSFXE.
        /// </summary>
        public const string ATSFXE = "ATSFXE";

        /// <summary>
        /// ATC76ATCF.
        /// </summary>
        public const string ATC76ATCF = "ATC76ATCF";

        /// <summary>
        /// ATUSER.
        /// </summary>
        public const string ATUSER = "ATUSER";

        /// <summary>
        /// ATPID.
        /// </summary>
        public const string ATPID = "ATPID";

        /// <summary>
        /// ATUPMJ.
        /// </summary>
        public const string ATUPMJ = "ATUPMJ";

        /// <summary>
        /// ATUPMT.
        /// </summary>
        public const string ATUPMT = "ATUPMT";

        /// <summary>
        /// ATJOBN.
        /// </summary>
        public const string ATJOBN = "ATJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76C0006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ATKCO", "ATKCO", JdeDataType.String, 10, true, true),
        new JdeField("ATDOC", "ATDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("ATDCT", "ATDCT", JdeDataType.String, 4, true, true),
        new JdeField("ATSFX", "ATSFX", JdeDataType.String, 6, true, true),
        new JdeField("ATSFXE", "ATSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("ATC76ATCF", "ATC76ATCF", JdeDataType.String, 2),
        new JdeField("ATUSER", "ATUSER", JdeDataType.String, 20),
        new JdeField("ATPID", "ATPID", JdeDataType.String, 20),
        new JdeField("ATUPMJ", "ATUPMJ", JdeDataType.Numeric),
        new JdeField("ATUPMT", "ATUPMT", JdeDataType.Numeric),
        new JdeField("ATJOBN", "ATJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C0006_0", "Primary Key on ATKCO, ATDOC, ATDCT, ATSFX, ATSFXE", new[] { "ATKCO", "ATDOC", "ATDCT", "ATSFX", "ATSFXE" }, isUnique: true, isPrimaryKey: true)
    };
}
