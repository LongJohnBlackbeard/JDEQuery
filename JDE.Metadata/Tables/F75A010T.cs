using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A010T - .
/// </summary>
public class F75A010T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A0AN8.
        /// </summary>
        public const string A0AN8 = "A0AN8";

        /// <summary>
        /// A0DT.
        /// </summary>
        public const string A0DT = "A0DT";

        /// <summary>
        /// A0FB1HRS.
        /// </summary>
        public const string A0FB1HRS = "A0FB1HRS";

        /// <summary>
        /// A0FB1VAL.
        /// </summary>
        public const string A0FB1VAL = "A0FB1VAL";

        /// <summary>
        /// A0FB1TAX.
        /// </summary>
        public const string A0FB1TAX = "A0FB1TAX";

        /// <summary>
        /// A0FB2HRS.
        /// </summary>
        public const string A0FB2HRS = "A0FB2HRS";

        /// <summary>
        /// A0FB2VAL.
        /// </summary>
        public const string A0FB2VAL = "A0FB2VAL";

        /// <summary>
        /// A0FB2TAX.
        /// </summary>
        public const string A0FB2TAX = "A0FB2TAX";

        /// <summary>
        /// A0FB3HRS.
        /// </summary>
        public const string A0FB3HRS = "A0FB3HRS";

        /// <summary>
        /// A0FB3VAL.
        /// </summary>
        public const string A0FB3VAL = "A0FB3VAL";

        /// <summary>
        /// A0FB3TAX.
        /// </summary>
        public const string A0FB3TAX = "A0FB3TAX";

        /// <summary>
        /// A0FB4HRS.
        /// </summary>
        public const string A0FB4HRS = "A0FB4HRS";

        /// <summary>
        /// A0FB4VAL.
        /// </summary>
        public const string A0FB4VAL = "A0FB4VAL";

        /// <summary>
        /// A0FB4TAX.
        /// </summary>
        public const string A0FB4TAX = "A0FB4TAX";

        /// <summary>
        /// A0FUAHRS.
        /// </summary>
        public const string A0FUAHRS = "A0FUAHRS";

        /// <summary>
        /// A0FUAVAL.
        /// </summary>
        public const string A0FUAVAL = "A0FUAVAL";

        /// <summary>
        /// A0FUATAX.
        /// </summary>
        public const string A0FUATAX = "A0FUATAX";

        /// <summary>
        /// A0FULHRS.
        /// </summary>
        public const string A0FULHRS = "A0FULHRS";

        /// <summary>
        /// A0FULVAL.
        /// </summary>
        public const string A0FULVAL = "A0FULVAL";

        /// <summary>
        /// A0FEXHRS.
        /// </summary>
        public const string A0FEXHRS = "A0FEXHRS";

        /// <summary>
        /// A0FEXVAL.
        /// </summary>
        public const string A0FEXVAL = "A0FEXVAL";

        /// <summary>
        /// A0FEAHRS.
        /// </summary>
        public const string A0FEAHRS = "A0FEAHRS";

        /// <summary>
        /// A0FEAVAL.
        /// </summary>
        public const string A0FEAVAL = "A0FEAVAL";

        /// <summary>
        /// A0FELHRS.
        /// </summary>
        public const string A0FELHRS = "A0FELHRS";

        /// <summary>
        /// A0FELVAL.
        /// </summary>
        public const string A0FELVAL = "A0FELVAL";

        /// <summary>
        /// A0USER.
        /// </summary>
        public const string A0USER = "A0USER";

        /// <summary>
        /// A0PID.
        /// </summary>
        public const string A0PID = "A0PID";

        /// <summary>
        /// A0UPMJ.
        /// </summary>
        public const string A0UPMJ = "A0UPMJ";

        /// <summary>
        /// A0JOBN.
        /// </summary>
        public const string A0JOBN = "A0JOBN";

        /// <summary>
        /// A0UPMT.
        /// </summary>
        public const string A0UPMT = "A0UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75A010T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A0AN8", "A0AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("A0DT", "A0DT", JdeDataType.Numeric, null, true, true),
        new JdeField("A0FB1HRS", "A0FB1HRS", JdeDataType.Numeric),
        new JdeField("A0FB1VAL", "A0FB1VAL", JdeDataType.Numeric),
        new JdeField("A0FB1TAX", "A0FB1TAX", JdeDataType.Numeric),
        new JdeField("A0FB2HRS", "A0FB2HRS", JdeDataType.Numeric),
        new JdeField("A0FB2VAL", "A0FB2VAL", JdeDataType.Numeric),
        new JdeField("A0FB2TAX", "A0FB2TAX", JdeDataType.Numeric),
        new JdeField("A0FB3HRS", "A0FB3HRS", JdeDataType.Numeric),
        new JdeField("A0FB3VAL", "A0FB3VAL", JdeDataType.Numeric),
        new JdeField("A0FB3TAX", "A0FB3TAX", JdeDataType.Numeric),
        new JdeField("A0FB4HRS", "A0FB4HRS", JdeDataType.Numeric),
        new JdeField("A0FB4VAL", "A0FB4VAL", JdeDataType.Numeric),
        new JdeField("A0FB4TAX", "A0FB4TAX", JdeDataType.Numeric),
        new JdeField("A0FUAHRS", "A0FUAHRS", JdeDataType.Numeric),
        new JdeField("A0FUAVAL", "A0FUAVAL", JdeDataType.Numeric),
        new JdeField("A0FUATAX", "A0FUATAX", JdeDataType.Numeric),
        new JdeField("A0FULHRS", "A0FULHRS", JdeDataType.Numeric),
        new JdeField("A0FULVAL", "A0FULVAL", JdeDataType.Numeric),
        new JdeField("A0FEXHRS", "A0FEXHRS", JdeDataType.Numeric),
        new JdeField("A0FEXVAL", "A0FEXVAL", JdeDataType.Numeric),
        new JdeField("A0FEAHRS", "A0FEAHRS", JdeDataType.Numeric),
        new JdeField("A0FEAVAL", "A0FEAVAL", JdeDataType.Numeric),
        new JdeField("A0FELHRS", "A0FELHRS", JdeDataType.Numeric),
        new JdeField("A0FELVAL", "A0FELVAL", JdeDataType.Numeric),
        new JdeField("A0USER", "A0USER", JdeDataType.String, 20),
        new JdeField("A0PID", "A0PID", JdeDataType.String, 20),
        new JdeField("A0UPMJ", "A0UPMJ", JdeDataType.Numeric),
        new JdeField("A0JOBN", "A0JOBN", JdeDataType.String, 20),
        new JdeField("A0UPMT", "A0UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A010T_0", "Primary Key on A0AN8, A0DT", new[] { "A0AN8", "A0DT" }, isUnique: true, isPrimaryKey: true)
    };
}
