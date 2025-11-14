using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q61 - .
/// </summary>
public class F43Q61 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BVBIDCODE.
        /// </summary>
        public const string BVBIDCODE = "BVBIDCODE";

        /// <summary>
        /// BVCMDCDE.
        /// </summary>
        public const string BVCMDCDE = "BVCMDCDE";

        /// <summary>
        /// BVITM.
        /// </summary>
        public const string BVITM = "BVITM";

        /// <summary>
        /// BVLLNB.
        /// </summary>
        public const string BVLLNB = "BVLLNB";

        /// <summary>
        /// BVLTIT.
        /// </summary>
        public const string BVLTIT = "BVLTIT";

        /// <summary>
        /// BVLSTSCR.
        /// </summary>
        public const string BVLSTSCR = "BVLSTSCR";

        /// <summary>
        /// BVURCD.
        /// </summary>
        public const string BVURCD = "BVURCD";

        /// <summary>
        /// BVURDT.
        /// </summary>
        public const string BVURDT = "BVURDT";

        /// <summary>
        /// BVURAT.
        /// </summary>
        public const string BVURAT = "BVURAT";

        /// <summary>
        /// BVURAB.
        /// </summary>
        public const string BVURAB = "BVURAB";

        /// <summary>
        /// BVURRF.
        /// </summary>
        public const string BVURRF = "BVURRF";

        /// <summary>
        /// BVTORG.
        /// </summary>
        public const string BVTORG = "BVTORG";

        /// <summary>
        /// BVUSER.
        /// </summary>
        public const string BVUSER = "BVUSER";

        /// <summary>
        /// BVPID.
        /// </summary>
        public const string BVPID = "BVPID";

        /// <summary>
        /// BVJOBN.
        /// </summary>
        public const string BVJOBN = "BVJOBN";

        /// <summary>
        /// BVUPMJ.
        /// </summary>
        public const string BVUPMJ = "BVUPMJ";

        /// <summary>
        /// BVTDAY.
        /// </summary>
        public const string BVTDAY = "BVTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q61";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BVBIDCODE", "BVBIDCODE", JdeDataType.String, 36, true, true),
        new JdeField("BVCMDCDE", "BVCMDCDE", JdeDataType.String, 30, true, true),
        new JdeField("BVITM", "BVITM", JdeDataType.Numeric, null, true, true),
        new JdeField("BVLLNB", "BVLLNB", JdeDataType.Numeric, null, true, true),
        new JdeField("BVLTIT", "BVLTIT", JdeDataType.String, 110),
        new JdeField("BVLSTSCR", "BVLSTSCR", JdeDataType.Numeric),
        new JdeField("BVURCD", "BVURCD", JdeDataType.String, 4),
        new JdeField("BVURDT", "BVURDT", JdeDataType.Numeric),
        new JdeField("BVURAT", "BVURAT", JdeDataType.Numeric),
        new JdeField("BVURAB", "BVURAB", JdeDataType.Numeric),
        new JdeField("BVURRF", "BVURRF", JdeDataType.String, 30),
        new JdeField("BVTORG", "BVTORG", JdeDataType.String, 20),
        new JdeField("BVUSER", "BVUSER", JdeDataType.String, 20),
        new JdeField("BVPID", "BVPID", JdeDataType.String, 20),
        new JdeField("BVJOBN", "BVJOBN", JdeDataType.String, 20),
        new JdeField("BVUPMJ", "BVUPMJ", JdeDataType.Numeric),
        new JdeField("BVTDAY", "BVTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q61_0", "Primary Key on BVBIDCODE, BVCMDCDE, BVITM, BVLLNB", new[] { "BVBIDCODE", "BVCMDCDE", "BVITM", "BVLLNB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43Q61_2", "Index on BVBIDCODE, BVCMDCDE, BVITM", new[] { "BVBIDCODE", "BVCMDCDE", "BVITM" })
    };
}
