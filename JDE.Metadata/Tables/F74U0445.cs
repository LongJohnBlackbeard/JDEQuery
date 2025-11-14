using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0445 - .
/// </summary>
public class F74U0445 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RNPYID.
        /// </summary>
        public const string RNPYID = "RNPYID";

        /// <summary>
        /// RNRC5.
        /// </summary>
        public const string RNRC5 = "RNRC5";

        /// <summary>
        /// RNKCO.
        /// </summary>
        public const string RNKCO = "RNKCO";

        /// <summary>
        /// RNDCTM.
        /// </summary>
        public const string RNDCTM = "RNDCTM";

        /// <summary>
        /// RNDOC.
        /// </summary>
        public const string RNDOC = "RNDOC";

        /// <summary>
        /// RNSFX.
        /// </summary>
        public const string RNSFX = "RNSFX";

        /// <summary>
        /// RNSFXE.
        /// </summary>
        public const string RNSFXE = "RNSFXE";

        /// <summary>
        /// RNGFL1.
        /// </summary>
        public const string RNGFL1 = "RNGFL1";

        /// <summary>
        /// RNPAAP.
        /// </summary>
        public const string RNPAAP = "RNPAAP";

        /// <summary>
        /// RNATXA.
        /// </summary>
        public const string RNATXA = "RNATXA";

        /// <summary>
        /// RNATXN.
        /// </summary>
        public const string RNATXN = "RNATXN";

        /// <summary>
        /// RNAA.
        /// </summary>
        public const string RNAA = "RNAA";

        /// <summary>
        /// RNURC1.
        /// </summary>
        public const string RNURC1 = "RNURC1";

        /// <summary>
        /// RNURDT.
        /// </summary>
        public const string RNURDT = "RNURDT";

        /// <summary>
        /// RNURAB.
        /// </summary>
        public const string RNURAB = "RNURAB";

        /// <summary>
        /// RNURAT.
        /// </summary>
        public const string RNURAT = "RNURAT";

        /// <summary>
        /// RNURRF.
        /// </summary>
        public const string RNURRF = "RNURRF";

        /// <summary>
        /// RNUSER.
        /// </summary>
        public const string RNUSER = "RNUSER";

        /// <summary>
        /// RNUPMT.
        /// </summary>
        public const string RNUPMT = "RNUPMT";

        /// <summary>
        /// RNUPMJ.
        /// </summary>
        public const string RNUPMJ = "RNUPMJ";

        /// <summary>
        /// RNPID.
        /// </summary>
        public const string RNPID = "RNPID";

        /// <summary>
        /// RNJOBN.
        /// </summary>
        public const string RNJOBN = "RNJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0445";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RNPYID", "RNPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("RNRC5", "RNRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("RNKCO", "RNKCO", JdeDataType.String, 10, true, true),
        new JdeField("RNDCTM", "RNDCTM", JdeDataType.String, 4, true, true),
        new JdeField("RNDOC", "RNDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RNSFX", "RNSFX", JdeDataType.String, 6, true, true),
        new JdeField("RNSFXE", "RNSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("RNGFL1", "RNGFL1", JdeDataType.String, 2),
        new JdeField("RNPAAP", "RNPAAP", JdeDataType.Numeric),
        new JdeField("RNATXA", "RNATXA", JdeDataType.Numeric),
        new JdeField("RNATXN", "RNATXN", JdeDataType.Numeric),
        new JdeField("RNAA", "RNAA", JdeDataType.Numeric),
        new JdeField("RNURC1", "RNURC1", JdeDataType.String, 6),
        new JdeField("RNURDT", "RNURDT", JdeDataType.Numeric),
        new JdeField("RNURAB", "RNURAB", JdeDataType.Numeric),
        new JdeField("RNURAT", "RNURAT", JdeDataType.Numeric),
        new JdeField("RNURRF", "RNURRF", JdeDataType.String, 30),
        new JdeField("RNUSER", "RNUSER", JdeDataType.String, 20),
        new JdeField("RNUPMT", "RNUPMT", JdeDataType.Numeric),
        new JdeField("RNUPMJ", "RNUPMJ", JdeDataType.Numeric),
        new JdeField("RNPID", "RNPID", JdeDataType.String, 20),
        new JdeField("RNJOBN", "RNJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0445_0", "Primary Key on RNPYID, RNRC5, RNKCO, RNDCTM, RNDOC, RNSFX, RNSFXE", new[] { "RNPYID", "RNRC5", "RNKCO", "RNDCTM", "RNDOC", "RNSFX", "RNSFXE" }, isUnique: true, isPrimaryKey: true)
    };
}
