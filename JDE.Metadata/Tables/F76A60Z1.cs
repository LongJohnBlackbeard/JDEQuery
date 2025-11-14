using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A60Z1 - .
/// </summary>
public class F76A60Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TFEDUS.
        /// </summary>
        public const string TFEDUS = "TFEDUS";

        /// <summary>
        /// TFEDBT.
        /// </summary>
        public const string TFEDBT = "TFEDBT";

        /// <summary>
        /// TFEDTN.
        /// </summary>
        public const string TFEDTN = "TFEDTN";

        /// <summary>
        /// TFVLDT.
        /// </summary>
        public const string TFVLDT = "TFVLDT";

        /// <summary>
        /// TFAOTT.
        /// </summary>
        public const string TFAOTT = "TFAOTT";

        /// <summary>
        /// TFPYID.
        /// </summary>
        public const string TFPYID = "TFPYID";

        /// <summary>
        /// TFACLE.
        /// </summary>
        public const string TFACLE = "TFACLE";

        /// <summary>
        /// TFACVA.
        /// </summary>
        public const string TFACVA = "TFACVA";

        /// <summary>
        /// TFADEA.
        /// </summary>
        public const string TFADEA = "TFADEA";

        /// <summary>
        /// TFADNU.
        /// </summary>
        public const string TFADNU = "TFADNU";

        /// <summary>
        /// TFAPTT.
        /// </summary>
        public const string TFAPTT = "TFAPTT";

        /// <summary>
        /// TFARDA.
        /// </summary>
        public const string TFARDA = "TFARDA";

        /// <summary>
        /// TFACOD.
        /// </summary>
        public const string TFACOD = "TFACOD";

        /// <summary>
        /// TFURRF.
        /// </summary>
        public const string TFURRF = "TFURRF";

        /// <summary>
        /// TFURCD.
        /// </summary>
        public const string TFURCD = "TFURCD";

        /// <summary>
        /// TFURDT.
        /// </summary>
        public const string TFURDT = "TFURDT";

        /// <summary>
        /// TFURAT.
        /// </summary>
        public const string TFURAT = "TFURAT";

        /// <summary>
        /// TFURAB.
        /// </summary>
        public const string TFURAB = "TFURAB";

        /// <summary>
        /// TFUSER.
        /// </summary>
        public const string TFUSER = "TFUSER";

        /// <summary>
        /// TFPID.
        /// </summary>
        public const string TFPID = "TFPID";

        /// <summary>
        /// TFJOBN.
        /// </summary>
        public const string TFJOBN = "TFJOBN";

        /// <summary>
        /// TFUPMJ.
        /// </summary>
        public const string TFUPMJ = "TFUPMJ";

        /// <summary>
        /// TFTDAY.
        /// </summary>
        public const string TFTDAY = "TFTDAY";

        /// <summary>
        /// TFADSTS.
        /// </summary>
        public const string TFADSTS = "TFADSTS";

        /// <summary>
        /// TFMCU.
        /// </summary>
        public const string TFMCU = "TFMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F76A60Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFEDUS", "TFEDUS", JdeDataType.String, 20, true, true),
        new JdeField("TFEDBT", "TFEDBT", JdeDataType.String, 30, true, true),
        new JdeField("TFEDTN", "TFEDTN", JdeDataType.String, 44, true, true),
        new JdeField("TFVLDT", "TFVLDT", JdeDataType.Numeric),
        new JdeField("TFAOTT", "TFAOTT", JdeDataType.String, 2),
        new JdeField("TFPYID", "TFPYID", JdeDataType.Numeric),
        new JdeField("TFACLE", "TFACLE", JdeDataType.String, 4),
        new JdeField("TFACVA", "TFACVA", JdeDataType.String, 20),
        new JdeField("TFADEA", "TFADEA", JdeDataType.String, 20),
        new JdeField("TFADNU", "TFADNU", JdeDataType.Numeric),
        new JdeField("TFAPTT", "TFAPTT", JdeDataType.String, 2),
        new JdeField("TFARDA", "TFARDA", JdeDataType.Numeric),
        new JdeField("TFACOD", "TFACOD", JdeDataType.Numeric),
        new JdeField("TFURRF", "TFURRF", JdeDataType.String, 30),
        new JdeField("TFURCD", "TFURCD", JdeDataType.String, 4),
        new JdeField("TFURDT", "TFURDT", JdeDataType.Numeric),
        new JdeField("TFURAT", "TFURAT", JdeDataType.Numeric),
        new JdeField("TFURAB", "TFURAB", JdeDataType.Numeric),
        new JdeField("TFUSER", "TFUSER", JdeDataType.String, 20),
        new JdeField("TFPID", "TFPID", JdeDataType.String, 20),
        new JdeField("TFJOBN", "TFJOBN", JdeDataType.String, 20),
        new JdeField("TFUPMJ", "TFUPMJ", JdeDataType.Numeric),
        new JdeField("TFTDAY", "TFTDAY", JdeDataType.Numeric),
        new JdeField("TFADSTS", "TFADSTS", JdeDataType.String, 2),
        new JdeField("TFMCU", "TFMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A60Z1_0", "Primary Key on TFEDUS, TFEDBT, TFEDTN", new[] { "TFEDUS", "TFEDBT", "TFEDTN" }, isUnique: true, isPrimaryKey: true)
    };
}
