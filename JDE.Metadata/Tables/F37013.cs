using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F37013 - .
/// </summary>
public class F37013 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TRTSTRSNM.
        /// </summary>
        public const string TRTSTRSNM = "TRTSTRSNM";

        /// <summary>
        /// TRDSC1.
        /// </summary>
        public const string TRDSC1 = "TRDSC1";

        /// <summary>
        /// TRAMIN.
        /// </summary>
        public const string TRAMIN = "TRAMIN";

        /// <summary>
        /// TRPMIN.
        /// </summary>
        public const string TRPMIN = "TRPMIN";

        /// <summary>
        /// TRQTRG.
        /// </summary>
        public const string TRQTRG = "TRQTRG";

        /// <summary>
        /// TRPMAX.
        /// </summary>
        public const string TRPMAX = "TRPMAX";

        /// <summary>
        /// TRAMAX.
        /// </summary>
        public const string TRAMAX = "TRAMAX";

        /// <summary>
        /// TRRSUM.
        /// </summary>
        public const string TRRSUM = "TRRSUM";

        /// <summary>
        /// TRCDEC.
        /// </summary>
        public const string TRCDEC = "TRCDEC";

        /// <summary>
        /// TRQABLRUL.
        /// </summary>
        public const string TRQABLRUL = "TRQABLRUL";

        /// <summary>
        /// TRNUMT.
        /// </summary>
        public const string TRNUMT = "TRNUMT";

        /// <summary>
        /// TRURCD.
        /// </summary>
        public const string TRURCD = "TRURCD";

        /// <summary>
        /// TRURAT.
        /// </summary>
        public const string TRURAT = "TRURAT";

        /// <summary>
        /// TRURRF.
        /// </summary>
        public const string TRURRF = "TRURRF";

        /// <summary>
        /// TRURAB.
        /// </summary>
        public const string TRURAB = "TRURAB";

        /// <summary>
        /// TRURDT.
        /// </summary>
        public const string TRURDT = "TRURDT";

        /// <summary>
        /// TRUSER.
        /// </summary>
        public const string TRUSER = "TRUSER";

        /// <summary>
        /// TRPID.
        /// </summary>
        public const string TRPID = "TRPID";

        /// <summary>
        /// TRUPMJ.
        /// </summary>
        public const string TRUPMJ = "TRUPMJ";

        /// <summary>
        /// TRTDAY.
        /// </summary>
        public const string TRTDAY = "TRTDAY";

        /// <summary>
        /// TRSY.
        /// </summary>
        public const string TRSY = "TRSY";

        /// <summary>
        /// TRRT.
        /// </summary>
        public const string TRRT = "TRRT";
    }

    /// <inheritdoc />
    public override string TableName => "F37013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TRTSTRSNM", "TRTSTRSNM", JdeDataType.String, 60, true, true),
        new JdeField("TRDSC1", "TRDSC1", JdeDataType.String, 60),
        new JdeField("TRAMIN", "TRAMIN", JdeDataType.String, 30),
        new JdeField("TRPMIN", "TRPMIN", JdeDataType.String, 30),
        new JdeField("TRQTRG", "TRQTRG", JdeDataType.String, 30),
        new JdeField("TRPMAX", "TRPMAX", JdeDataType.String, 30),
        new JdeField("TRAMAX", "TRAMAX", JdeDataType.String, 30),
        new JdeField("TRRSUM", "TRRSUM", JdeDataType.String, 6),
        new JdeField("TRCDEC", "TRCDEC", JdeDataType.String, 2),
        new JdeField("TRQABLRUL", "TRQABLRUL", JdeDataType.String, 10),
        new JdeField("TRNUMT", "TRNUMT", JdeDataType.String, 2),
        new JdeField("TRURCD", "TRURCD", JdeDataType.String, 4),
        new JdeField("TRURAT", "TRURAT", JdeDataType.Numeric),
        new JdeField("TRURRF", "TRURRF", JdeDataType.String, 30),
        new JdeField("TRURAB", "TRURAB", JdeDataType.Numeric),
        new JdeField("TRURDT", "TRURDT", JdeDataType.Numeric),
        new JdeField("TRUSER", "TRUSER", JdeDataType.String, 20),
        new JdeField("TRPID", "TRPID", JdeDataType.String, 20),
        new JdeField("TRUPMJ", "TRUPMJ", JdeDataType.Numeric),
        new JdeField("TRTDAY", "TRTDAY", JdeDataType.Numeric),
        new JdeField("TRSY", "TRSY", JdeDataType.String, 8),
        new JdeField("TRRT", "TRRT", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F37013_0", "Primary Key on TRTSTRSNM", new[] { "TRTSTRSNM" }, isUnique: true, isPrimaryKey: true)
    };
}
